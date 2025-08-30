using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        char[] A = before.ToCharArray();
        char[] B = after.ToCharArray();
        
        Array.Sort(A);
        Array.Sort(B);
        
        for(int i=0; i<A.Length;i++){
            if(A[i]!=B[i]){
                return 0;
            }
        }

        return 1;
    }
}