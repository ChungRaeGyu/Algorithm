using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        List<int> answer = new List<int>();
        int num = 2;
        while(n!=1){
            if(n%num==0){
                if(!dic.ContainsKey(num)){
                    dic.Add(num,num);
                }
                n/=num;
            }else{
                num++;
            }
        }
        
        foreach(var a in dic){
            answer.Add(a.Value);
        }
        return answer.ToArray();
    }
}