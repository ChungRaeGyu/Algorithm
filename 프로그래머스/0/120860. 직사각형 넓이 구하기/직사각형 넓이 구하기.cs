using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        int x = dots[0,0];
        int y = dots[0,1];
        int dx =0;
        int dy = 0;
        for(int i=0; i<dots.GetLength(0);i++){
            if(x!=dots[i,0]){
                dx = Math.Abs(dots[i,0]-x);
            }
            if(y!=dots[i,1]){
                dy = Math.Abs(dots[i,1]-y);
            }
        }
        answer = dx*dy;
        return answer;
    }
}