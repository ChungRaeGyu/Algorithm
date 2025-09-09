using System;

public class Solution {
    public int solution(int chicken) {
        int answer = 0;
        int temp =0;
        while(chicken/10!=0){
            answer += chicken/10;
            temp = chicken%10;
            chicken/=10;
            chicken+=temp;
        }

//1081 -> 108 + 1 = 109 ->10 + 9 = 19 -> 1 +9 = 10 -> 1+0 = 1 -> 0+ 1
            
        return answer;
    }
}