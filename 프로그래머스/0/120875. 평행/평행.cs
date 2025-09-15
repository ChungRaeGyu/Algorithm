using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] dots) {
        List<int[,]> dxy = new List<int[,]>();
        int temp = 0;
        for(int i=0; i<dots.GetLength(0);i++){
            for(int j=i+1; j<dots.GetLength(0);j++){
                int dx = dots[i,0]-dots[j,0];
                int dy = dots[i,1]-dots[j,1];
                int num = Division(Math.Abs(dx),Math.Abs(dy));
                dxy.Add(new int[,]{{dx/num,dy/num}});
            }
        }
        foreach(int[,] a in dxy){
            foreach(int[,] b in dxy){
                if(b[0,0]*a[0,1]==a[0,0]*b[0,1]){
                    temp++;
                    Console.Write(a[0,0] + " , " +  b[0,0]);
                }
            }
            Console.WriteLine("k");
            if(temp==2||temp==6){
                return 1;
            }else{
                Console.WriteLine(temp);
            }
            temp=0;
        }
        
        
        return 0;
    }
    public int Division(int a, int b){
        //기약분수 만들기
        while(b!=0){
            int r = a%b;
            a = b;
            b = r;
        }
        return a;
    }
}