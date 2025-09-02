using System;
using System.Collections.Generic;
using System.Text;
public class Solution {
    public string solution(string a, string b) {
        StringBuilder str = new StringBuilder();
        Stack<int> answer = new Stack<int>();
        List<int> la = new List<int>();
        List<int> lb = new List<int>();
        
        int num = 0;
        
        foreach(char c in a){
            la.Add((int)c-48);
        }
        foreach(char c in b){
            lb.Add((int)c-48);
        }
        
        int minus = la.Count-lb.Count;
        if(minus<0){
            for(int i=0; i<Math.Abs(minus);i++){
                la.Insert(0,0);
            }
        }else{
            for(int i=0; i<minus;i++){
                lb.Insert(0,0);
            }
        }
        for(int i=lb.Count-1; i>=0;i--){
            int temp = la[i]+lb[i];
            if(num==1){
                temp++;
            }
            num = temp/10;
            answer.Push(temp%10);
        }
        if(num==1){
            answer.Push(1);
        }
        foreach(int ii in answer){
            str.Append(ii);
        }
        return str.ToString();
    }
}