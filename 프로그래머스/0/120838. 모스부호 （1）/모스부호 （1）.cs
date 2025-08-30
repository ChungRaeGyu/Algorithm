using System;
using System.Text;
public class Solution {
    public string solution(string letter) {
        StringBuilder answer = new StringBuilder();
        string[] moss = new string[]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        string[] temp = letter.Split(" ");
        
        for(int i=0; i<temp.Length;i++){
            int num=0;
            foreach(string str in moss){
                if(str.Equals(temp[i])){
                    break;
                }
                num++;
            }
            Console.Write((char)(num+97));
            answer.Append((char)(num+97));
        }
        Console.Write((int)'a');
        return answer.ToString();
    }
}