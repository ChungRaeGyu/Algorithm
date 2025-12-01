using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        Array.Sort(lottos);
        Array.Sort(win_nums);
        int num = 0;
        int correct = 0;
        int[] lank = new int[]{6,5,4,3,2,1};
        int[] answer = new int[2];
        
        for(int i=0; i<lottos.Length;i++){
            if(lottos[i]==0){
                num++;
            }else{
                for(int j=0; j<lottos.Length;j++){
                    if(lottos[i] == win_nums[j])
                        correct++;
                }
            }
        }
        if(correct+num==0){
            answer[0] = lank[0];
            answer[1] = lank[0];
        }else{
            answer[0] = lank[correct+num-1];
            answer[1] = lank[correct==0?0:correct-1];
        }
        return answer;
    }
}