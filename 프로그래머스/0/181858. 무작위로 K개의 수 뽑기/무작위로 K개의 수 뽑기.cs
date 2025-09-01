using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int k) {
        List<int> temp = new List<int>();
        
        foreach(int i in arr){
            if(temp.Count==k)
                return temp.ToArray();
            if(!temp.Contains(i))
                temp.Add(i);
        }
        
        for(int i=temp.Count;i<k;i++){
            temp.Add(-1);
        }
        return temp.ToArray();
    }
}