using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[,] lines) {
        int answer = 0;
        int[] arr = new int[200];
        for(int i=0; i<lines.GetLength(0);i++){
            int start = lines[i,0]+100;
            int end = lines[i,1]+100;
            
            for(int j=start;j<end;j++){
                arr[j]++;
            }
        }
        foreach(int n in arr){
            if(n>=2)answer++;
        }
        return answer;
    }
}