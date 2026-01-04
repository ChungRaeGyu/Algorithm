using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> ing = new List<int>(ingredient);
        int num = 0;
        
        while(num+3<ing.Count){
            if (num < 0) 
                num = 0;
            if(check(num,ing)){
                answer++;
                num -=3;
            }else{
                num++;
            }
            
        }
        return answer;
    }
    
    public bool check(int start,List<int> temp){
        int[] num = new int[4]{1,2,3,1};
        bool c = true;
        for(int i=start; i<start+4;i++){
            if(num[i-start]!=temp[i]){
                c = false;
                break;
            }
        }
        if(c){
            for(int i=start; i<start+4;i++){
                temp.RemoveAt(start);
            }
        }
        return c;
    }
}