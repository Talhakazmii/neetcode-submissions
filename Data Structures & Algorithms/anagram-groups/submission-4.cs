public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var words = strs.GroupBy(x=>CreateKey(x)).ToDictionary(c=>c.Key,c=>c.ToList());
        List<List<string>> lstToReturn = new List<List<string>>();
        foreach(var pair in words){
            lstToReturn.Add(pair.Value);
        }
        return lstToReturn;
    }

   public string CreateKey(string word){
       int[] wordArr = new int[26]; 
       StringBuilder stringToReturn = new StringBuilder();
       foreach(var c in word){
          wordArr[c -'a']++;
       }
       
       for(int i = 0; i < wordArr.Length; i++){
         if(wordArr[i] > 0){
            stringToReturn.Append((char)(i + 'a'));
            stringToReturn.Append(wordArr[i]);
            stringToReturn.Append('#');
         }
       }
       return stringToReturn.ToString();
     
   }
}
