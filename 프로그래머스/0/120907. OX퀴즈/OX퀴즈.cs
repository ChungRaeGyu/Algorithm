using System;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.Length];
        int num=0;
        foreach(string str in quiz){
            string[] temp = str.Split(" ");
            int a = int.Parse(temp[0]);
            int b = int.Parse(temp[2]);
            int result = int.Parse(temp[4]);
            switch(temp[1]){
                case "-": answer[num]=(a-b)==result?"O":"X";
                    break;
                case "+": answer[num]= (a+b)==result?"O":"X";
                    break;
            }
            num++;
        }
        return answer;
    }
}