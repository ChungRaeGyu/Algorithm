using System;
using System.Collections.Generic;
using System.Text;
public class Solution {
    public string[] solution(string my_str, int n) {
        StringBuilder sb = new StringBuilder();
        List<string> answer = new List<string>();
        for(int i=1; i<=my_str.Length;i++){
            sb.Append(my_str[i-1]);
            if(i%(n)==0&&i!=0){
                answer.Add(sb.ToString());
                sb.Clear();
            }
        }
        if(sb.Length!=0){
            answer.Add(sb.ToString());
        }
        return answer.ToArray();
    }
}