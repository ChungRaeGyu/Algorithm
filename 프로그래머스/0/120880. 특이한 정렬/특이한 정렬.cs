using System;

public class Solution {
    public int[] solution(int[] numlist, int n) {
        Array.Sort(numlist,(a,b)=>{
            int disA = Math.Abs(a-n);  //3
            int disB = Math.Abs(b-n);  //2
            
            if(disA!=disB){
                return  disA-disB; //return 값이 양수면 b,a가 되고 음수면은 a,b가 된다. 
            }
            return b-a;
        });
        return numlist;
    }
}