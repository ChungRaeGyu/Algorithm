using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        while(order!=0){
            int temp = order%10;
            if(temp%3==0&&temp!=0)
                answer++;
            order/=10;
            Console.WriteLine(temp);
        }
        return answer;
    }
}