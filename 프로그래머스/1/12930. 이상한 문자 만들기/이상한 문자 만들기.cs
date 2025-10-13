using System.Text;
public class Solution {
    public string solution(string s) {
        StringBuilder answer = new StringBuilder();
        string[] temp = s.Split(" ");
        
        for(int j=0; j<temp.Length;j++){
            if(j!=0){
                answer.Append(" "); 
            }
            for(int i=0; i<temp[j].Length;i++){
                char t = temp[j][i];
                if(i%2==0){
                    answer.Append(t.ToString().ToUpper());
                }else{
                    answer.Append(t.ToString().ToLower());
                }
            }
        }
        return answer.ToString();
    }
}