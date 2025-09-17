using System;

public class Solution {
    public string solution(string polynomial) {
        string answer = "0";
        string[] str = polynomial.Split(" ");
        int x = 0;
        int num =0;
        
        foreach(string s in str){
            if(s.Equals("+")) continue;
            if(s.Contains("x")){
                string[] sb = s.Split("x");
                int j=0;
                if(int.TryParse(sb[0],out j)){
                    x+=j;
                }else{
                    x+=1;
                }
            }else{
                num+=int.Parse(s);
            }
        }
        
        if(num==0&&x!=0){
            return x!=1 ? $"{x}x":$"x";
        }
        if(x!=0&&num!=0){
            return x!=1 ? $"{x}x + {num}":$"x + {num}";
        }
        if(x==0){
            return $"{num}";
        }
        return answer;
    }
}