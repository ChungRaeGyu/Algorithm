using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        List<int> list = new List<int>();
        
        int sqrt = (int)Math.Sqrt(total);
        int temp = sqrt+1;
        
        while(total!=0||list.Count!=num){
            if(list.Count<num){
                list.Add(sqrt);
                total-=sqrt;
                sqrt--;     
                Console.WriteLine(total);
            }else{
                int t = list[list.Count-1];
                list.RemoveAt(list.Count-1);
                total+=t;
                total-= temp;
                list.Insert(0,temp);
                temp++;
            }
        }
        answer = list.ToArray();
        Array.Sort(answer);
        return answer;
    }
}