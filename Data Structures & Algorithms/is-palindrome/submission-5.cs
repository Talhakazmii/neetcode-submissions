public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length == 1)
             return true;

        
        
        StringBuilder word = new StringBuilder();
        

        foreach(var c in s.ToLower()){
            if((c >= 65 && c <= 90) || (c >= 97 && c <= 122) ||  (c >= '0' && c <= '9') ){
                word.Append(c);
            }
        }
        
        if(word.Length == 1){
           return true;
        }

        var pointer1 = 0;
        var pointer2 = word.Length-1;
        for(int i = 0; i < word.Length; i++){
          if(word[i] != word[pointer2-i]){
             Console.WriteLine(word[pointer1]);
             Console.WriteLine(word[pointer2]);
             Console.WriteLine();
             return false;
          }
        }

        return true;
    }
}
