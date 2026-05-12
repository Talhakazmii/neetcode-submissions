public class Solution {
    public int MaxProfit(int[] prices) {
        var _buy = prices[0];
        var profit = 0;
        for(int i = 1 ; i < prices.Length; i++){
           if(prices[i] - _buy < 0){
             _buy = prices[i];
             continue;
           }else{
            if(profit < ( prices[i] - _buy)){
                profit = prices[i] - _buy;
            }
           }
             
           
        }

        return profit;
    }
}
