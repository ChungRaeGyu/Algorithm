using System;

public class Solution {
    public int solution(string binomial) {
        int answer = 0;
        bool change = false;
        string op = "";
        string sa="";
        string sb="";
        int a = 0;
        int b = 0;
        int num=1;
        
        foreach(char ch in binomial){
            if((int)ch-48<0){                
                op += ch;
                change = true;
            }else if(!change){
                sa+=ch;
            }else
                sb+=ch;
        }
        for(int i=sa.Length-1;i>=0; i--){
            a+=((int)sa[i]-48)*num;
            num*=10;
        }
        num=1;
        for(int i=sb.Length-1;i>=0;i--){
            b+=((int)sb[i]-48)*num;
            num*=10;
        }
        string ot = op.Trim();

        switch(ot){
            case "+":
                    answer = a+b;
                    break;
            case "-":
                    answer = a-b;
                    break;
            case "*":
                    answer = a*b;
                    break;
            default : Console.Write(op);
                break;
        }
        return answer;
    }
}