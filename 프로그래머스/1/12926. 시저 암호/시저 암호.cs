using System;
public class Solution {
    public string solution(string s, int n) {
        string answer = "";  
        
        Console.WriteLine((int)'z');
        Console.WriteLine((int)'Z');
        
        foreach(char c in s){
            if(c.Equals(' ')){
                answer+=" ";
                continue;
            }
            
            if(char.IsUpper(c)){
                int num = (int)c+n>(int)'Z'?(int)c+n-(int)'Z':(int)c+n-(int)'A'+1;
                answer += (char)((int)'A'+num-1);
            }else{
                int num = (int)c+n>(int)'z'?(int)c+n-(int)'z':(int)c+n-(int)'a'+1;
                answer += (char)((int)'a'+num-1);
            }
            
        }
        return answer;
    }
}