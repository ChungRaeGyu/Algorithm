using System;
using System.Linq;
public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int Max = array.Max()+1;
        int[] Count = new int[Max];
        foreach(int a in array){
            Count[a]++;
        }
        int Cmax = Count.Max();
        int num=0;//중복체크
        int temp=0; //임시저장
        for(int i=0; i<Count.Length;i++){
            if(Cmax==Count[i]){
                num++;
                temp = i;
            }
            if(num>=2){
                return -1;
            }
        }
        answer = temp;
        return answer;
    }
}