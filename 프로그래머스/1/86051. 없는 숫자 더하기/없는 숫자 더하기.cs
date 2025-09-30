using System;
using System.Text;
public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        StringBuilder sb = new StringBuilder();
        string temp;
        foreach(int n in numbers){
            sb.Append(n);
        }
        temp = sb.ToString();
        for(int i=1;i<10;i++){
            if(!temp.Contains(i.ToString())){
                answer+=i;
            }
        }
        return answer;
    }
}