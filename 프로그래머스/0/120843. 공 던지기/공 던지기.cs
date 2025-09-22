using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int num = 1;
        while(k!=1){
            k--;
            num+=2;
            if(numbers.Length<num){
                num-=numbers.Length;
            }
        }
        return num;
    }
}