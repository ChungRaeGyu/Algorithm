using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = new List<int>();
        int length = arr.Length;
        int temp =1;
        int r=0;
        while(temp<length){
            temp*=2;
        }
        r = temp-length;
        answer = arr.ToList();
        for(int i=0; i<r;i++){
            answer.Add(0);
        }
        
        
        return answer.ToArray();
    }
}