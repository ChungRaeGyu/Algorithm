using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        
        
        foreach(char ch in s){
            answer+=(char)(MadePassword(ch,skip,index));
        }
        return answer;
    }
    
    private int MadePassword(char ch,string skip,int index){
        int num = 0;
        int tempch = (int)(ch);
        while(num<index){
            tempch +=1;
            if(tempch>(int)('z')){
                tempch = (int)('a');
            }
            if(!skip.Contains((char)(tempch))){
                num++;
            }
            
        }
        return tempch;
    }
}