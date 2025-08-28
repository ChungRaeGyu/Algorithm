using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        if(arr1.Length>arr2.Length){
            answer=1;
        }else if(arr1.Length<arr2.Length){
            answer = -1;
        }else{
            int temp1=0;
            int temp2=0;
            for(int i=0; i<arr1.Length;i++){
                temp1+=arr1[i];
                temp2+=arr2[i];
            }
            answer = temp1>temp2?1:(temp1==temp2?0:-1);
        }
        return answer;
    }
}