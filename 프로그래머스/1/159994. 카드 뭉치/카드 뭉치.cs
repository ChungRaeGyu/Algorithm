using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        Queue<string> s1 = new Queue<string>(cards1);
        Queue<string> s2 = new Queue<string>(cards2);
        
        foreach(string s in goal){
            if(s1.Count!=0&&s.Equals(s1.Peek())){
                s1.Dequeue();
                continue;
            }
            if(s2.Count!=0 && s.Equals(s2.Peek())){
                s2.Dequeue();
                continue;
            }
            return "No";
        }
        return "Yes";
    }
}