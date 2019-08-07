using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class AVote
    {
        public ArrayList candidateList { get; set; }
        public ArrayList voteCandidate { get; set; }

        public AVote(ArrayList candidateList, ArrayList voteCandidate)
        {
            this.candidateList = candidateList;
            this.voteCandidate = voteCandidate;
        //Make the length of VoteCandidate list is the same to length of candidateList
        while (this.candidateList.Count != this.voteCandidate.Count)
        {
            this.voteCandidate.Add(-1);
        }
        }

        public override String ToString()
        {
            return this.showAllVoteForCandidate();
        }

        public static List<T> ConvertFromArrayList<T>(ArrayList list)
        {
            List<T> cp_list = new List<T>();
            foreach (Object item in list)
                cp_list.Add((T)item);
            return cp_list;

        }

        public static ArrayList ConvertFromList<T>(List<T> list)
        {
            ArrayList cp_list = new ArrayList();
            foreach (T item in list)
                cp_list.Add(item);
            return cp_list;
        }
    public String showAllCandidate()
    {
        String returnValue = "";
        for (int i = 0; i < this.candidateList.Count; i++)
        {
            if (i < this.candidateList.Count - 1)
                returnValue += this.candidateList[i] + ",";
            else
                returnValue += this.candidateList[i];
        }

        return returnValue;
    }

    public String showAllVoteForCandidate()
    {
        String returnValue = "";
        for (int i = 0; i < this.voteCandidate.Count; i++)
        {
            if (i < this.voteCandidate.Count - 1)
                returnValue += this.voteCandidate[i].ToString() + ",";
            else
                returnValue += this.voteCandidate[i].ToString();
        }

        return returnValue;
    }

    public Boolean voteForIndexOfCandidate(int index, int input)
    {  
        //Check invalid input( in range)
        if(!(input > 0 && input <= this.candidateList.Count))
        {
            return false;
        }
        //Check is it valid number(input)
        for(int i=0; i< voteCandidate.Count; i++)
        {
            if(input == Convert.ToInt32(voteCandidate[i]))
            {
                return false;
            }
        }
        this.voteCandidate[index] = input;
        return true;

    }



    public Boolean isValidVote()
    {
        for(int i=0; i < this.voteCandidate.Count; i++)
        {
            try
            {
                if (!(Convert.ToInt32(this.voteCandidate[i]) <= this.voteCandidate.Count && Convert.ToInt32(this.voteCandidate[i]) > 0))
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }
        return true;
    }

    }



