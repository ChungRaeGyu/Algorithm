using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int sum =1;
        int num = 1;
        int temp = 0;

        while(true){
            sum *=num;
            temp = sum;
            temp *=(num+1);
            if(temp>n){
                return num;
            }
            num++;
        }
        return answer;
    }
}