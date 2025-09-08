using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string bin1, string bin2) {
        string answer = "";
        Stack<int> stack = new Stack<int>();
        
        int a = Calc(bin1);
        int b = Calc(bin2);
        int num = a+b;
        
        if(num==0){
            return "0";
        }
        while(num!=1){
            stack.Push(num%2);
            num/=2;
        }
        stack.Push(num);
        
        while(stack.Count!=0){
            answer+=stack.Pop();
        }
        
        return answer;
    }
    public int Calc(string str){
        int strLength = str.Length-1;
        int sum = 0;
        foreach(char ch in str){
            if(ch=='1'){
                sum+=doubleup(strLength);
            }
            strLength--;
        }
        return sum;
    }
    public int doubleup(int count){
        int num = 1;
        if(count==0){
            return 1;
        }
        for(int i=0; i<count;i++){
            num*=2;
        }
        return num;
    }
}