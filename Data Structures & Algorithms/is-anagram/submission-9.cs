public class Solution {
    public bool IsAnagram(string s, string t) {
       if(s.Length != t.Length){
        return false;
       }
       StringBuilder str = new StringBuilder(s,s.Length);

       for(int i = 0; i <= t.Length-1; i++){
           if(!str.ToString().Contains(t[i])){
             return false;
           }

           var index = str.ToString().IndexOf(t[i]);
           str.Remove(index,1);

       }

       return true;
    }
}
