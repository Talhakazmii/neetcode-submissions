public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums.Length == 2){
            return new int[] {0,1};
        }

        Dictionary<int, int> numbers = new Dictionary<int,int>();
        for(int i =0; i<=nums.Length; i++){
            if(numbers.TryGetValue(target-nums[i], out int value)){
                return new int[] {value,i};
            }
            else
            {
               numbers[nums[i]] = i;
            }

        }


        return new int[] {0,1};
    }
}
