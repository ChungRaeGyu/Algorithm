using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        Stack<int> answer = new Stack<int>();
        for(int i=0; i<flag.Length;i++){
            if(flag[i]){
                for(int j=0; j<arr[i]*2;j++){
                    answer.Push(arr[i]);
                }
            }else{
                for(int j=0; j<arr[i];j++){
                    answer.Pop();
                }
            }
        }
        int[] an = answer.ToArray();  
        Array.Reverse(an);
        
        return an;
    }
}