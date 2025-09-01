using System;
using System.Text;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string myStr) {
        StringBuilder sb  = new StringBuilder();
        List<string> answer = new List<string>();
        int num = 0;
        foreach(char str in myStr){
            if(str.Equals('a')||str.Equals('b')||str.Equals('c')){
                if(sb.Length!=0){
                    answer.Add(sb.ToString());
                    sb = new StringBuilder();
                }
            }else{
                sb.Append(str);
            }
        }
        if(sb.Length!=0){
            answer.Add(sb.ToString());
        }
        if(answer.Count==0){
            answer.Add("EMPTY");
        }
        return answer.ToArray();
    }
}