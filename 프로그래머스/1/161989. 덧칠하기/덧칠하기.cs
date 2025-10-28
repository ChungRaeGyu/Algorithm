using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int num = 1;
        int tempM = m;
        int temp = 0;
        Array.Sort(section);
        for(int i=0; i<section.Length-1;i++){
            if(section[i+1]-section[i]<tempM){
                num++;
                tempM -=section[i+1]-section[i];
            }else{
                temp = num%m==0?num/m:num/m+1;
                answer +=temp;
                num = 1;
                tempM = m;
            }
        }
        temp = num%m==0?num/m:num/m+1;
        answer +=temp;
        return answer;
    }
}