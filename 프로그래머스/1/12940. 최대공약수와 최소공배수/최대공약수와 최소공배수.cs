public class Solution {
    public int[] solution(int n, int m) {
        //최대 공약수, 최소 공배수
        int[] answer;
        int num = Calc(n,m);
        int num2 = n*m/num;
        
        answer = new int[]{num,num2};
        return answer;
    }
    private int Calc(int a, int b){
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}