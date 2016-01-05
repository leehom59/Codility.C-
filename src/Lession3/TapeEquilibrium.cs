using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geekors.Codility.Lession3
{
    /// <summary>
    /// https://codility.com/programmers/task/tape_equilibrium/
    /// Minimize the value |(A[0] + ... + A[P-1]) - (A[P] + ... + A[N-1])|
    /// </summary>
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int ArrayLength = A.Length;
            int MinValue = -1;
            for (int i = 1; i < ArrayLength; i++)
            {
                int LeftSum = 0, RightSum = 0, TotalSum = 0;
                for (int j = 0; j < i; j++)
                {
                    LeftSum += A[j];
                }
                for (int x = i; x < A.Length; x++)
                {
                    RightSum += A[x];
                }
                TotalSum = LeftSum - RightSum;
                if (TotalSum < 0) TotalSum *= -1;

                if (MinValue == -1) MinValue = TotalSum;
                else if (TotalSum < MinValue) MinValue = TotalSum;
            }
            return MinValue;
        }
    }
}
