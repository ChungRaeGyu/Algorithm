using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n) {
        Queue<int> queue = new Queue<int>();
        bool check = true;
        int answer = 0;
        while(n!=0){
            queue.Enqueue(n%3);
            n/=3;
        }
        
        while(queue.Count!=0){
            int temp = queue.Dequeue();
            
            if(temp!=0&&check){
                check = false;
            }
            
            if(!check){
                answer+=temp*(int)Math.Pow(3,queue.Count);
            }
        }
        return answer;

    }
}