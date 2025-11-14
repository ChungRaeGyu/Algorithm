using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int num=0;
        char check='a';
        for(int i=0; i<s.Length;i++){
            if(num==0){
                check = s[i];
                answer++;
            }
            if(s[i]==check){
                num++;
            }else{
                num--;
            }
        }
        return answer;
    }
}