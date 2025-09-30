using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int divisor) {

        List<int> sort = new List<int>();
        
        foreach(int n in arr){
            if(n%divisor==0){
                sort.Add(n);
            }
        }
        if(sort.Count==0){
            return new int[]{-1};
        }
        sort.Sort();
        return sort.ToArray();
    }
}