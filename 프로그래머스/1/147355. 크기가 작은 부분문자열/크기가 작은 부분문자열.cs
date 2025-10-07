using System;
public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        int length = p.Length;
        for(int i = 0; i<=t.Length-length ; i++){
            string temp = t.Substring(i,length);
            if(long.Parse(temp)<=long.Parse(p)){
                answer++;
            }
            Console.WriteLine(temp);
            
        }
        
        return answer;
    }
}