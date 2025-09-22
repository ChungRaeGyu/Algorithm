using System;

public class Solution {
    public int solution(int balls, int share) {
        int answer = 0;
        //ballsCshare
        double num1=1;
        double num2=1;
        if(balls/2<share){
            share = balls-share;
        }
        while(share!=0){
            num1*=balls;
            num2*=share;
            balls--;
            share--;
        }

        return (int)(num1/num2);
    }
}