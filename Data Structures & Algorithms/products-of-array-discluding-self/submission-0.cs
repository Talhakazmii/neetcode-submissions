public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prefix = 1;
        int suffix = 1;
        int[] answer = new int[nums.Length];
        

        //Calculating Prefix
        for(int i = 0; i < nums.Length; i++){
            if(i == 0){
                answer[i] = 1;
                continue;
            }
            else{
                prefix *= nums[i-1];
                answer[i] = prefix;
            }

        }

        //Calculating Suffix
        for(int i = nums.Length-1; i >= 0; i--){
            if(i == nums.Length-1){
                int value = suffix * answer[i];
                answer[i] = value;
                continue;
            }
            else{
                suffix *= nums[i+1];
                int value = suffix * answer[i];
                answer[i] = value;
            }

        }
       
       return answer;
        
    }
}
