using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string s) {
        string answer = "";
        List<char> cList = new List<char>();
        foreach(char c in s){
            int temp =0;
            foreach(char ch in s){
                if(c==ch){
                    temp++;
                }
                if(temp>=2){
                    break;
                }
            }
            if(temp==1){
                cList.Add(c);
            }
        }
        cList.Sort();
        foreach(char c in cList){
            answer+=c;
        }
        return answer;
    }
}