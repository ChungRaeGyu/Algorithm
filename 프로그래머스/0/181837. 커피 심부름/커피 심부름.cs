using System;

public class Solution {
    public int solution(string[] order) {
        int answer = 0;
        foreach(string str in order){
            if(str.Contains("latte"))
                answer++;
            
        }
        
        answer = (order.Length-answer)*4500+(answer*5000);
        return answer;
    }
}