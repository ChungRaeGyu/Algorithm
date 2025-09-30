using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = new List<int>();
        int min = arr.Min();
        int index = Array.IndexOf(arr,min);
                                  
        if(arr.Length==1){
            return new int[]{-1};
        }
        for(int i=0; i<arr.Length;i++){
            if(i!=index){
                answer.Add(arr[i]);
            }
        }
        return answer.ToArray();
    }
}