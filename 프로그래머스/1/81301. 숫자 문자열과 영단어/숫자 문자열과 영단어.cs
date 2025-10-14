using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string str = "";
        string temp = "";
        foreach(char c in s){
            str+=c;
            switch(str){
                case "zero":
                case "0":
                    temp+="0";
                    str="";
                    break;
                case "one":
                case "1":
                    temp+="1";
                    str="";
                    break;
                case "two":
                case "2":
                    temp+="2";
                    str="";
                    break;
                case "three":
                case "3":
                    temp+="3";
                    str="";
                    break;
                case "four":
                case "4":
                    temp+="4";
                    str="";
                    break;
                case "five":
                case "5":
                    temp+="5";
                    str="";
                    break;
                case "six":
                case "6":
                    temp +="6";
                    str="";
                    break;
                case "seven":
                case "7":
                    temp+="7";
                    str="";
                    break;
                case "eight":
                case "8":
                    temp+="8";
                    str="";
                    break;
                case "nine":
                case "9":
                    temp+="9";
                    str="";
                    break;                
            }
        }
        return int.Parse(temp);
    }
}