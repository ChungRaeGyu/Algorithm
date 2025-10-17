using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        int[] temp;
        for(int i=0; i<commands.GetLength(0);i++){
            int a = commands[i,0];
            int j = commands[i,1];
            int k = commands[i,2];
            temp = new int[j-a+1];
            for(int ii = 0; ii<temp.Length; ii++){
                temp[ii] = array[ii+a-1];
            }
            Array.Sort(temp);
            answer[i] = temp[k-1];
            
            
        }
        return answer;
    }
}