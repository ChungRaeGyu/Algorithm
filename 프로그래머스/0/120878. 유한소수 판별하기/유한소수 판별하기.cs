using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        int n =2;
        Dictionary<int,int> key = new Dictionary<int,int>();
        List<int> num = new List<int>();
        //a의 인수들을 이용해 큰거부터 b를나누어서 최대한 나눠준다.
        while(a!=1){
            if(a%n==0){
                num.Add(n);
                a/=n;
            }else{
                n++;
            }
        }
        foreach(int i in num){
            if(b%i==0){
                b/=i;
            }
        }
        
        //소인수 분해 끝 
        Console.Write(b);
        n = 2;
        while(b!=1){
            if(b%n==0){
                b/=n;
                key[n]=1;
            }else{
                n++;
            }
        }
        Console.WriteLine(key.Count);
        if(key.Count>2){
            return 2;
        }else{
            foreach(var k in key){
                if(k.Key==2){
                    continue;
                }
                if(k.Key==5){
                    continue;
                }
                return 2;
                
            }
        }
        return 1;
    }
}