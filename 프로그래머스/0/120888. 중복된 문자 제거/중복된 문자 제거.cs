using System;
using System.Linq;
public class Solution {
    public string solution(string my_string) {
        string answer = "";
        answer = string.Concat(my_string.Distinct());
        //Distinct로 문자열의 중복을 제거하고 char형 배열로 가져온다.
        
        return answer;
    }
}