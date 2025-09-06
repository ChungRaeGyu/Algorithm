using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string A, string B) {
        int answer = 0;
        int temp = A.Length;
        if(B.Equals(A)){
            return answer;
        }
        while(temp!=-1){
            string ta = A.Substring(0,A.Length-1);
            string tb = A.Substring(A.Length-1,1);
            A = (tb+ta);
            answer++;
            temp--;
            if(B.Equals(A)){
                return answer;
            }
        }
        
        return -1;
    }
}