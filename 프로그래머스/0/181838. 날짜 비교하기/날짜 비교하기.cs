using System;

public class Solution {
    public int solution(int[] date1, int[] date2) {
        int answer = 0;
        for(int i=0; i<date1.Length;i++){
            if(date1[i]!=date2[i]){
                return answer = date1[i]<date2[i]?1:0;
            }
        }
        return 0;
    }
}