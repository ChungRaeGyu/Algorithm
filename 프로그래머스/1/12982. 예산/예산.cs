using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        Array.Sort(d);
        Console.WriteLine("시작");
        foreach(int n in d){
            if(budget<n){
                break;
            }
            budget-=n;
            answer++;

        }
        return answer;
    }
}