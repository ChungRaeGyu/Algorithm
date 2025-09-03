using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        int[,] answer;
        int x = arr.GetLength(0);
        int y = arr.GetLength(1);
        
        if(x>y){
            answer = new int[x,x];
            
            for(int i=0; i<x;i++){
                for(int j=0; j<x;j++){
                    answer[i,j] = j>=y?0:arr[i,j];
                }
            }
        }else if(x<y){
            answer = new int[y,y];
            
            for(int i=0; i<y;i++){
                for(int j=0;j<y;j++){
                    answer[i,j] = i>=x?0:arr[i,j];
                }
            }
        }else{
            answer = arr;
        }
        return answer;
    }
}