using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[2];
        foreach(string str in keyinput){
            switch(str){
                case "up":
                    if(answer[1]!=board[1]/2){
                        answer[1]++;
                    }
                    break;
                case "down":
                    if(answer[1]!=-board[1]/2){
                        answer[1]--;
                    }
                    break;
                case "left":
                    if(answer[0]!=-board[0]/2){
                        answer[0]--;
                    }
                    break;
                case "right":
                    if(answer[0]!=board[0]/2){
                        answer[0]++;
                    }
                    break;
            }
        }
        return answer;
    }
}