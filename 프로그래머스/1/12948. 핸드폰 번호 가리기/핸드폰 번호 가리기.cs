using System.Text;
public class Solution {
    public string solution(string phone_number) {
        
        StringBuilder sb = new StringBuilder();
        int length = phone_number.Length;
        
        for(int i=0; i<length-4;i++){
            sb.Append("*");
        }
        sb.Append(phone_number.Substring(length-4));
        return sb.ToString();
    }
}