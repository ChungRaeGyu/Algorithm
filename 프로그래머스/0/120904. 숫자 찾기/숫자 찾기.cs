using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = 0;
        string temp = num.ToString();
        int n = temp.IndexOf(k.ToString());
        answer = n+1!=0?n+1:-1;
        Console.Write(num.ToString());
        return answer;
    }
}