using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int[,] answer = new int[num_list.Length/n,n]; //4,2
        
        int x=0;
        int y=0;
        for(int i=0; i<num_list.Length;i++){
            if(y==n){
                y=0;
                x++;
            }
            answer[x,y] = num_list[i];
            y++;

        }
        return answer;
    }
}