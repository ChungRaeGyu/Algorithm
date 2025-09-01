using System;

public class Solution {
    public int solution(string[] strArr) {
        int[] temp = new int[30];
        int max = temp[0];
        foreach(string str in strArr){
            temp[str.Length-1]++;
            if(max<temp[str.Length-1]){
                max = temp[str.Length-1];
            }
        }
        return max;
    }
}