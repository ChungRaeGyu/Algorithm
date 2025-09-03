using System;
using System.Text;

public class Solution {
    public string[] solution(string[] picture, int k) {
        string[] answer = new string[picture.Length*k];
        int num=0;
        StringBuilder sb = new StringBuilder();
        for(int i=0; i<picture.Length;i++){
            sb.Clear();
            foreach(char c in picture[i]){
                for(int j=0; j<k;j++){
                    sb.Append(c);
                }
            }
            for(int j=0; j<k;j++){
                answer[num++] = sb.ToString();
            }

        }
        return answer;
    }
}