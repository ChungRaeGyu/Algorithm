using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string n_str) {
        int answer = 0;
        List<char> temp = new List<char>();
        int num=1;
        foreach(char c in n_str){
            temp.Add(c);
        }
        
        for(int i=temp.Count-1; i>=0;i--){
            answer += (temp[i]-48)*num;
            num*=10;
        }
        return answer;
    }
}