using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPhoneDic
{
    public class Utility 
    {
        public int LevenshteinDistance(string A, string B)
        {
            int n = A.Length;
            int m = B.Length;
            //init
            int[,] problemMatrix = new int[m+1, n + 1];
            for(int i = 0; i < n + 1; i++) //A -> ""
            {
                problemMatrix[0, i] = i;
            }
            for (int i = 0; i < m + 1; i++) //B -> ""
            {
                problemMatrix[i, 0] = i;
            }
            //
            for(int i = 1; i < m + 1; i++)
            {
                for(int j = 1; j < n + 1; j++)
                {
                    problemMatrix[i, j] = (A[j-1] == B[i-1]) ? Min(problemMatrix[i - 1,j], problemMatrix[i - 1,j - 1], problemMatrix[i,j - 1]): Min(problemMatrix[i - 1,j], problemMatrix[i - 1,j - 1], problemMatrix[i,j - 1]) + 1;
                }
            }
            return problemMatrix[m,n];
        }
        public int Min(int a, int b, int c)
        {
            if(a < b)
            {
                return (b <= c) ? a : (a < c) ? a : c;
            }
            else
            {
                return (a <= c) ? b : (b <= c) ? b : c;
            }
        }
    }
}
