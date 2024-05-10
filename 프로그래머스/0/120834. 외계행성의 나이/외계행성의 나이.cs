using System;

public class Solution {
    public string solution(int age) {
        string answer = "";        
        int temp=age;
        for(int i=0; i<age.ToString().Length;i++){
            answer =(char)(temp%10+97)+answer;
            temp /= 10;
        }

        return answer;
    }
}