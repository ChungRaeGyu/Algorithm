using System;
using System.Text;
public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        StringBuilder sb = new StringBuilder();
        foreach(char ch in myString){
            char temp = ch=='A'?'B':'A';
            sb.Append(temp);
        }
        answer = sb.ToString().Contains(pat)?1:0;
        return answer;
    }
}