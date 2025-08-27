using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        List<int> answer = new List<int>();
        List<int> delete = new List<int>();
        answer = arr.ToList();
        for(int i=0; i<answer.Count;i++){
            for(int j=0 ; j<delete_list.Length;j++){
                if(arr[i]==delete_list[j]){
                    delete.Add(arr[i]);
                }
            }
        }
        
        foreach(int n in delete){
            answer.Remove(n);
        }
        
        return answer.ToArray();
    }
}