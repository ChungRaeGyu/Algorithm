using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] array, int n) {
        int answer = array[0];
        int min = Math.Abs(array[0]-n);
        List<int> list = new List<int>();
        foreach(int num in array){
            if(min>Math.Abs(num-n)){
                answer = num;
                min = Math.Abs(num-n);
            }else if(min==Math.Abs(num-n)){
                if(answer>num){
                    answer = num;
                }
            }
        }
        return answer;
    }
}