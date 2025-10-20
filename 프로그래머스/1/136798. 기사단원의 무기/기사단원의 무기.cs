using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        int count = 0;
        //1번 약수의 개수 구하기
        for(int i=1; i<=number;i++){
            count = Divisor(i);
            if(count>limit){
                answer+=power;
            }else{
                answer+=count;
            }
            
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Divisor(int num){
        int count = 0;
        if(num>=4){
            int sqrt = (int)Math.Sqrt(num);
            for(int i=1; i<=sqrt;i++){
                if(num%i==0){
                    count++;
                }
            }
            if(num==Math.Pow(sqrt,2)){
                count = count*2-1;
            }else{
                count = count*2;
            }
        }else{
            for(int i=1; i<=num;i++){
                if(num%i==0){
                    count++;
                }
            }
        }

        return count;
    }
}