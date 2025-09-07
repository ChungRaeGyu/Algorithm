using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        foreach(int num in array){
            int i = num;
            while(i!=0){
                int temp = i%10;
                i/=10;
                if(temp==7){
                    answer++;
                }
            }
        }
        return answer;
    }
}