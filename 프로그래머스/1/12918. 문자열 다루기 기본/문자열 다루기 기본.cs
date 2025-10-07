using System;
public class Solution {
    public bool solution(string s) {
        bool answer = true;
        int num=0;
        if(s.Length==4||s.Length==6){
            if(int.TryParse(s,out num)){
                return true;
                Console.Write(num);
            }else{
                return false;
            }  
        }else{
            return false;
        }
          
    }
}