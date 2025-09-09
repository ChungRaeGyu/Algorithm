using System;

public class Solution {
    public int[] solution(int[,] score) {
        int[] answer = new int[score.GetLength(0)];
        int[] temp = new int[score.GetLength(0)];
        int num = 0;
        for(int i=0; i<temp.Length;i++){
            temp[i] = score[i,0]+score[i,1];
        }
        for(int i=0; i<answer.Length;i++){
            num = answer.Length+1;
            for(int j=0; j<temp.Length;j++){
                if(temp[i]>=temp[j]){
                    num--;
                }
            }
            answer[i]=num;
        }
        
        
        
        return answer;
    }
}