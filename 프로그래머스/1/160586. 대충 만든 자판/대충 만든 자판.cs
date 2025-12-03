using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        List<int> num = new List<int>();
        for(int i=0; i<targets.Length;i++){
            foreach(char c in targets[i]){
                for(int j=0; j<keymap.Length;j++){
                    int temp = keymap[j].IndexOf(c);
                    num.Add(temp);
                }
                int m = num.Max();
                if(m==-1){
                    answer[i] = -1;
                    break;
                }else{
                    num.Sort();
                    for(int j=0;j<num.Count;j++){
                        if(num[j]!=-1){
                            answer[i] += num[j]+1;
                            break;
                        }
                    }
                }
                num.Clear();
            }
        }
        return answer;
    }
}