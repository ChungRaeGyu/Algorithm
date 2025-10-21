using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> answer = new List<int>();
        int[][] source={
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 2, 1, 2, 3, 2, 4, 2, 5 },
            new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 }
                                  };
        int[] collect = new int[3];
        for(int i=0; i<answers.Length;i++){
            int num = answers[i];
            if(source[0][i%source[0].Length]==num){
                collect[0]++;
            }
            if(source[1][i%source[1].Length]==num){
                collect[1]++;
            }
            if(source[2][i%source[2].Length]==num){
                collect[2]++;
            }
        }
        
        int max = collect[0];
        for(int i=0; i<collect.Length;i++){
            if(max<collect[i]){
                max=collect[i];
                answer.Clear();
                answer.Add(i+1);
            }else if(max==collect[i]){
                answer.Add(i+1);
            }
        }
        
        
        return answer.ToArray();
    }
}