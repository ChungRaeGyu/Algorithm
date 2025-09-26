public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        
        foreach(int a in arr){
            answer+=a;
        }
        return answer/arr.Length;
    }
}