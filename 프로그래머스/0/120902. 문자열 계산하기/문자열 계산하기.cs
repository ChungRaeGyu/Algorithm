using System;

public class Solution {
    public int solution(string my_string) {
        //1 - 4 + 5 1 3 5
        int answer = 0;
        string temp = "+ "+my_string;
        string[] str =temp.Split(" ");
        
        for(int i=0; i<str.Length;i+=2){
            int a = int.Parse(str[i+1]);
            answer = str[i].Equals("+")?answer+a:answer-a;
            
        }
        return answer;
    }
}