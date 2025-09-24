using System;

public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[n,n];
        int[,] dir = new int[,]{{0,1},{-1,0},{0,-1},{1,0}};
        answer[0,0]=1;
        int num = 1;
        int index = 0;
        int x = 0;
        int y = 0;
        while(num!=n*n){
            
            if(index>=4){
                index=0;
            }
            int dx = x+dir[index,0];
            int dy = y+dir[index,1];
            
            if(dir[index,0]==0){
                if(dy>=n||dy<0||answer[dx,dy]!=0){
                    index++;
                    continue;
                }
            }else{
                if(dx>=n||dx<0||answer[dx,dy]!=0){
                    index++;
                    continue;
                }
            }
            
            answer[dx,dy]=++num;
            x = dx;
            y = dy;
        }
        
        return answer;
    }
}