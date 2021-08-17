//Brandon Broomell
//Date: 8/4/2021
//Codility challenge



using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
           Array.Sort(A);
           int len = A.Length;
           int lowest = 1;
            int i = 0;
            for(i = 0; i < len; i++)
            {
                if(A[i] > lowest)
                {
                    return lowest;
                }
                else if(A[i] == lowest){
                    lowest++;
                }
            }
            return lowest;
    }
}
