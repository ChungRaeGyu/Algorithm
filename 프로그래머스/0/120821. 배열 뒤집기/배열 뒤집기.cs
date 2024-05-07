using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length];
        /* 섞기
        for(int i = 0; i<answer.Length/2;i++){
            int temp = num_list[i];
            num_list[i] = num_list[num_list.Length-i-1];
            num_list[num_list.Length-i-1] = temp;
        }
        answer = num_list;
        return answer;
        */
        for(int i=0; i<answer.Length;i++){
            answer[i] = num_list[num_list.Length-i-1];
        }
        return answer;
    }
}