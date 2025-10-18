using System.Linq;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = new string[strings.Length];
        
        answer = strings.OrderBy(st=>st[n]).ThenBy(st=>st).ToArray();
        return answer;
    }
}