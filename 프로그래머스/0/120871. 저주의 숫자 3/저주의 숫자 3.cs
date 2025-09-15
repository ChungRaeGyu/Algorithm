using System;

public class Solution {
    public int solution(int n) {
        int answer = 1;
        int num = 1;
        int temp = 0;

        while(n>=num){
            temp = answer;
            if(answer%3!=0&&Check(answer)){                
                num++;
            }
            
            answer++;
            Console.WriteLine($"num : {num} , answer : {answer}");
        }
        return --answer;
    }
    
    public bool Check(int temp){
       while(temp!=0){
            if(temp%10==3){
                return false;                   
            }
            temp/=10;
        }
        return true;
    }
}