public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        string[] days = new string[]{"SUN","MON","TUE","WED","THU","FRI","SAT"};
        int[] month = new int[] {31,29,31,30,31,30,31,31,30,31,30,31};
        int sum = 0;
        
        for(int i=0; i<a-1;i++){
            sum+=month[i];
        }
        
        sum +=b-1;
        
        answer = days[(5+sum)%7];
        return answer;
    }
}