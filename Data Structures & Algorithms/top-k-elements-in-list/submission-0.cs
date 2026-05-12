public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int , int> numbers = new Dictionary<int, int>();
        List<int>[] numArr = new List<int>[nums.Length+1];

        foreach(var no in nums){
            if(numbers.TryGetValue(no, out int value)){
                numbers[no] = value + 1;
            }else{
                numbers[no] = 1;
            }
        }
        
        foreach(var pair in numbers){
             if(numArr[pair.Value] != null){
                numArr[pair.Value].Add(pair.Key);
             }else{
                numArr[pair.Value] = new List<int>(){pair.Key};
             }
        }

       List<int> arr = new List<int>();
       
       for(int i = numArr.Length-1; i >= 0 && k > 0; i-- ){
        if(numArr[i] != null){
           foreach(var item in numArr[i]){
               arr.Add(item);
               k--;
           }
           }
       }
        
      return arr.ToArray();
        
    }
}
