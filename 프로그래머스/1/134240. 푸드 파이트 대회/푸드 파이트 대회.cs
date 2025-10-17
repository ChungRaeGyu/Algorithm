using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        string temp = "";
        for(int i=1; i<food.Length;i++){
            if(food[i]/2>=1){
                for(int j=0; j<food[i]/2;j++){
                    answer+=i;
                    temp = i+temp;
                }
            }
        }
        return answer+"0"+temp;
    }
}