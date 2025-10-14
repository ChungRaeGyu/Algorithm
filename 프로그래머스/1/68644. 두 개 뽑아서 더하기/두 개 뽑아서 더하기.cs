using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        Dictionary<int,int> answer = new Dictionary<int,int>();
        List<int> list = new List<int>();
        Array.Sort(numbers);
        for(int i=0; i<numbers.Length-1;i++){
            for(int j=i+1;j<numbers.Length;j++){
                int sum = numbers[i]+numbers[j];
                answer[sum]=sum;
            }
        }
        
        foreach(var v in answer){
            list.Add(v.Value);
        }
        int[] temp = list.ToArray();
        Array.Sort(temp);
        return temp;
    }
}