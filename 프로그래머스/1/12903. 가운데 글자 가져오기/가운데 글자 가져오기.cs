public class Solution {
    public string solution(string s) {
        string answer = "";
        int length = s.Length;
        if(length%2==0){
            answer+=$"{s[length/2-1]}{s[length/2]}";
        }else{
            answer+=s[length/2];
        }
        return answer;
    }
}