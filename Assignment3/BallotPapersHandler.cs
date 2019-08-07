using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Agile_Assignment_3
{
    class BallotPapersHandler
    {
        Dictionary<string, Dictionary<AVote, int>> CandidateBallotFragments = new Dictionary<string, Dictionary<AVote, int>>();
        List<Dictionary<string, int>> RoundsResults = new List<Dictionary<string,int>>();
        List<int> RoundExhaustedBallots = new List<int>(),
                    RoundValidBallots = new List<int>(),
                    RoundMajority = new List<int>();
        int InvalidBallots = 0,
            TotalBallots = 0,
            CurrentRound = 0,
            TotalRounds = 0;
        public BallotPapersHandler(List<string> Candidates, List<AVote> Ballots)
        {
            this.TotalBallots = Ballots.Count;
            this.InvalidBallots = this.EliminateInvalidBallots(Ballots);
            this.GenerateCandidateBallotFragments(Candidates);
            this.DistributeBallotsByFirstPreference(Candidates, Ballots);
            this.OperateBallotCountingProcess(Candidates);
        }

        private List<int> ExtractBallotPreferences(string preferences)
        {
            List<int> list = new List<int>();
            foreach(string value in preferences.Split(','))
                list.Add(int.Parse(value));
            return list;
        }

        private int EliminateInvalidBallots(List<AVote> Ballots)
        {
            List<AVote> InvalidBallots = new List<AVote>();
            foreach (AVote Ballot in Ballots)
            {
                int index = 0;
                List<int> Preferences = this.ExtractBallotPreferences(Ballot.showAllVoteForCandidate());
                bool IsEliminated = false;
                do
                {
                    if (Preferences.Count(i => i == Preferences[index]) > 1 ||
                        Preferences[index] > Preferences.Count || Preferences[index] < 1)
                    {
                        InvalidBallots.Add(Ballot);
                        IsEliminated = true;
                    }
                    index++;
                } while (!IsEliminated && index < Preferences.Count);
            }

            foreach (AVote Ballot in InvalidBallots)
                Ballots.Remove(Ballot);
            return InvalidBallots.Count;
        }

        private void GenerateCandidateBallotFragments(List<string> Candidates)
        {
            foreach (string Candidate in Candidates)
                this.CandidateBallotFragments.Add(Candidate, new Dictionary<AVote, int>());
        }

        private void DistributeBallotsByFirstPreference(List<string> Candidates, List<AVote> Ballots)
        {
            foreach (AVote Ballot in Ballots)
            {
                int Index = 0;
                foreach(int Value in this.ExtractBallotPreferences(Ballot.showAllVoteForCandidate()))
                {
                    if(Value == 1)
                        this.CandidateBallotFragments[Candidates[Index]].Add(Ballot, 2);
                    Index++;
                }
            }
            Dictionary<string, int> Results = new Dictionary<string,int>();
            for(int i = 0; i < Candidates.Count; i++)
                Results.Add(Candidates[i], (this.CandidateBallotFragments.ContainsKey(Candidates[i])?
                    this.CandidateBallotFragments[Candidates[i]].Count : 0));
            this.RoundsResults.Add(Results);
            this.RoundExhaustedBallots.Add(0);
            this.RoundValidBallots.Add(this.TotalBallots - this.InvalidBallots - this.RoundExhaustedBallots[0]);
            this.RoundMajority.Add(this.RoundValidBallots[0] / 2 + 1);
            this.CurrentRound++;
            this.TotalRounds++;
        }

        private string FindTheLowestPreferredCandidate()
        {
            int MinPreference = int.MaxValue;
            List<string> LowestPreferredCandidates = new List<string>();
            Random Rand = new Random();
            foreach (KeyValuePair<string, Dictionary<AVote, int>> Fragment in this.CandidateBallotFragments)
            {
                if (Fragment.Value.Count < MinPreference)
                {
                    LowestPreferredCandidates.Clear();
                    LowestPreferredCandidates.Add(Fragment.Key);
                    MinPreference = Fragment.Value.Count;
                }
                else if (Fragment.Value.Count == MinPreference)
                    LowestPreferredCandidates.Add(Fragment.Key);
            }
            if (LowestPreferredCandidates.Count == 1)
                return LowestPreferredCandidates[0];
            else
                return LowestPreferredCandidates[Rand.Next(LowestPreferredCandidates.Count)];
        }

        private void DistributeBallotsOfEliminatedCandidate(string Candidate, List<string> Candidates)
        {
            int ExhaustedBallots = 0;
            foreach (KeyValuePair<AVote, int> Ballot in this.CandidateBallotFragments[Candidate])
            {
                bool IsDistributed = false;
                int Index = 0;
                KeyValuePair<AVote, int> Copy = Ballot;
                while (Copy.Value <= this.ExtractBallotPreferences(Copy.Key.showAllVoteForCandidate()).Count &&
                    !IsDistributed)
                {
                    foreach (int Value in this.ExtractBallotPreferences(Copy.Key.showAllVoteForCandidate()))
                    {
                        if (Value == Copy.Value && this.CandidateBallotFragments.ContainsKey(Candidates[Index]))
                        {
                            this.CandidateBallotFragments[Candidates[Index]].Add(Copy.Key, Copy.Value + 1);
                            IsDistributed = true;
                        }
                        Index++;
                    }
                    if (!IsDistributed)
                        Copy = new KeyValuePair<AVote, int>(Copy.Key, Copy.Value + 1);
                    Index = 0;
                }
                if(!IsDistributed)
                    ExhaustedBallots++;
            }
            this.CandidateBallotFragments.Remove(Candidate);
            Dictionary<string, int> Results = new Dictionary<string, int>();
            for (int i = 0; i < Candidates.Count; i++)
                Results.Add(Candidates[i], (this.CandidateBallotFragments.ContainsKey(Candidates[i]) ?
                    this.CandidateBallotFragments[Candidates[i]].Count : 0));
            this.RoundsResults.Add(Results);
            this.RoundExhaustedBallots.Add(ExhaustedBallots);
            this.RoundValidBallots.Add(this.TotalBallots - ExhaustedBallots - this.InvalidBallots);
            this.RoundMajority.Add(this.RoundValidBallots[this.CurrentRound] / 2 + 1);
            this.CurrentRound++;
            this.TotalRounds++;
        }

        public string FindTheWinner()
        {
            int MaxPreference = int.MinValue;
            List<string> HighestPreferredCandidates = new List<string>();
            Random Rand = new Random();
            foreach (KeyValuePair<string, Dictionary<AVote, int>> Fragment in this.CandidateBallotFragments)
            {
                if (Fragment.Value.Count > MaxPreference)
                {
                    HighestPreferredCandidates.Clear();
                    HighestPreferredCandidates.Add(Fragment.Key);
                    MaxPreference = Fragment.Value.Count;
                }
                if (Fragment.Value.Count == MaxPreference)
                    HighestPreferredCandidates.Add(Fragment.Key);
            }
            if (MaxPreference >= this.RoundMajority[this.CurrentRound - 1])
            {
                if (HighestPreferredCandidates.Count == 1)
                    return HighestPreferredCandidates[0];
                else
                    return HighestPreferredCandidates[Rand.Next(HighestPreferredCandidates.Count)];
            }
            else
                return "";
        }

        private void OperateBallotCountingProcess(List<string> Candidates)
        {
            while (this.FindTheWinner() == "" && this.RoundValidBallots.Count == 0)
                this.DistributeBallotsOfEliminatedCandidate(this.FindTheLowestPreferredCandidate(), Candidates);
        }

        public int GetTotalBallotCount()
        {
            return this.TotalBallots;
        }

        public List<int> GetRoundsValidBallots()
        {
            return this.RoundValidBallots;
        }

        public int GetInvalidBallotCount()
        {
            return this.InvalidBallots;
        }

        public List<int> GetRoundsExhaustedBallots()
        {
            return this.RoundExhaustedBallots;
        }

        public List<int> GetRoundsMajorities()
        {
            return this.RoundMajority;
        }

        public List<Dictionary<string, int>> GetResultsForEachRound()
        {
            return this.RoundsResults;
        }
    }
}
