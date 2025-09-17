using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        Array.Sort(sides);
        foreach(int a in sides){
            Console.WriteLine(a);
        }
        for(int i=sides[1]+1;i<sides[0]+sides[1];i++){
            answer++;
        }
        int ii=sides[1];
        while(sides[1]<sides[0]+ii){
            answer++;
            ii--;
        }
        
        //가장 긴변이 sides[1] <sides[0] + i;
        return answer;
    }
}