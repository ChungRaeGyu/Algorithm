using System;
public class Solution {
    public int solution(int n) {
        int answer = 0;
        bool check = true;
        int sqrt;
        for(int i=2; i<=n;i++){
            sqrt = (int)Math.Sqrt(i);
            check = true;
            for(int j=2;j<=sqrt;j++){
                if(i%j==0){
                    check = false;
                    break;
                }                  
            }
            if(check){
                answer++;
            }
        }
        return answer;
    }
}