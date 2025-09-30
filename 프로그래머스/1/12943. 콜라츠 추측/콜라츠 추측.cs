public class Solution {
    public int solution(long num) {
        int n = 0;
        while(n<=500){
            
            if(num==1){
                return n;
            }
            if(num%2==0){
                num/=2;
            }else{
                num = num*3+1;
            }
            n++;            
        }
        return -1;
    }
}