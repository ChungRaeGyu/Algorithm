using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int answer = 0;
        int[] num = new int[3];
        List<int> list = new List<int>();
        for(int i=0; i<rank.Length;i++){
            if(attendance[i])
                list.Add(rank[i]);
        }
        
        list.Sort();
        for(int i=0; i<3;i++){
            num[i] = list[i];
        }
        
        for(int i=0; i<rank.Length;i++){
            if(num[0]==rank[i]){
                num[0]=i;
                break;
            }
        }
        for(int i=0; i<rank.Length;i++){
            if(num[1]==rank[i]){
                num[1]=i;
                break;
            }
        }
        for(int i=0; i<rank.Length;i++){
            if(num[2]==rank[i]){
                num[2]=i;
                break;
            }
        }
        
        answer = (10000*num[0])+(100*num[1])+num[2];
        return answer;
    }
}