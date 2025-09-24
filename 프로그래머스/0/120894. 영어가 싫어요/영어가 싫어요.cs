using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
public class Solution {
    public long solution(string numbers) {
        Dictionary<string,string> dic = new Dictionary<string,string>();
        string temp = "zero, one ,two, three, four, five, six, seven, eight, nine";
        string[] str = temp.Split(",").Select(s=>s.Trim()).ToArray();
        StringBuilder sb = new StringBuilder();
        StringBuilder answer = new StringBuilder();
        int num =0;
        foreach(string s in str){
            dic.Add(s,$"{num}");
            num++;
        }
        foreach(char c in numbers){
            sb.Append(c);
            if(dic.ContainsKey(sb.ToString())){
                answer.Append(dic[sb.ToString()]);
                sb.Clear();
            }
        }
        string t = answer.ToString();
        return long.Parse(t);
    }
}