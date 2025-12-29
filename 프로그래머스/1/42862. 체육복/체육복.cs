using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = n;
        HashSet<int> reserveSet = new HashSet<int>(reserve);
        HashSet<int> lostSet = new HashSet<int>(lost);
        
        foreach (int r in reserve)
        {
            if (lostSet.Contains(r))
            {
                reserveSet.Remove(r);
                lostSet.Remove(r);
            }
        }
        int[] sortedLost = lostSet.ToArray();
        Array.Sort(sortedLost);
        
        foreach (int l in sortedLost)
        {
            if (reserveSet.Contains(l - 1))
                reserveSet.Remove(l - 1);
            else if (reserveSet.Contains(l + 1))
                reserveSet.Remove(l + 1);
            else
                answer--;
        }
        
        return answer;
    }
}