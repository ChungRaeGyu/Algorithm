using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int lastNum = 0;
        string[] str = s.Split(" ");
        
        foreach(string ss in str){
            if(ss.Equals("Z")){
                answer -= lastNum;
            }else{
                lastNum = int.Parse(ss);
                answer += lastNum;
            }
        }
        return answer;
    }
}