using System;

class Solution
{
    public long solution(long price, long money, long count)
    {
        long totalPrice = (count*(1+count)/2)*price-money;
        return totalPrice>=0?totalPrice:0;
    }
}