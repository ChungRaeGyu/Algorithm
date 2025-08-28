using System;

public class Solution {
    public string solution(string n_str) {
        string answer = "";
        int index =0;
        
        for(int i=0; i<n_str.Length;i++){
            if(n_str[i]!='0'){
                index = i;
                break;
            }
        }
        answer = n_str.Substring(index,n_str.Length-index);
        return answer;
    }
}