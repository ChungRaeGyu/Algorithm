using System;
using System.Text;
public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int num =0;
        StringBuilder sb = new StringBuilder();
        //연달아서 있는 숫자?
        //문자열을 분리한다.
        //반복문은 한글자씩임
        //숫자로 바꿀 수 있을때는 문자열을 만들고 끊겼을 때 넘기기
        foreach(var c in my_string){
            if(int.TryParse(c.ToString(),out num)){
                sb.Append(c);
            }else{
                if(sb.Length!=0){
                    answer = answer+int.Parse(sb.ToString());
                    sb.Clear();  
                }   
            }
        }
        if(sb.Length!=0)
            answer = answer+int.Parse(sb.ToString());
            
        return answer;
    }
}