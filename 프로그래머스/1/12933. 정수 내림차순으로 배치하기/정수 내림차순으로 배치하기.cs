using System;
using System.Linq;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] ch = n.ToString().ToCharArray();
        Array.Sort(ch);
        Array.Reverse(ch);
        answer = long.Parse(ch);
        return answer;
    }
}