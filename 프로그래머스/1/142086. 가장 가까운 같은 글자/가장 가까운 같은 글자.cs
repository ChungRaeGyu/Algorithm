using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        
        for(int i=0; i<s.Length;i++){
            char temp = s[i]; //문자 한개를 뽑은것
            
            int num = s.IndexOf(temp.ToString());

            if(num==i){
                answer[i] = -1;
            }else{
                int j = i-1;
                while(j>=0){
                    if(temp.Equals(s[j])){
                        answer[i] = i-j;
                        break;
                    }
                    j--;
                }
            }
            
            
            
        }
        return answer;
    }
}