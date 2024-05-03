using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = 0;
        foreach(int a in numbers){
            answer+=a;
        }
        answer = answer/numbers.Length;
        return answer;
    }
}