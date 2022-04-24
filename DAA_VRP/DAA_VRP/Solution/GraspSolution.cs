﻿namespace DAA_VRP
{
    public class GraspSolution : Solution
    {
        public int rlcSize = -1;
        

        public GraspSolution(string problemId, int numberOfClients, int rlcSize)
        {
            string[] splittedProblemId = problemId.Split('\\');
            this.problemId = splittedProblemId[splittedProblemId.Length - 1];
            this.rlcSize = rlcSize;
            this.numberOfClients = numberOfClients;
        }

        public override string GetInfoString()
        {
            throw new NotImplementedException();
        }

    }
}
