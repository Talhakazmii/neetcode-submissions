public class Solution {
    public bool IsAnagram(string s, string t) {
           if(s.Length != t.Length){
            return false;
           }

           Dictionary<char, int> sDic = new Dictionary<char,int>();
           for(int i = 0; i<=s.Length-1;i++){
              if(sDic.TryGetValue(s[i], out int value)){
                  sDic[s[i]] = value + 1; 
              }else{
                sDic[s[i]] = 1;
              }
              
           }

           for(int i = 0; i <= t.Length-1 ; i++){
              if(sDic.TryGetValue(t[i], out int value)){
                sDic[t[i]] = value - 1;
              }
              continue;
           }

           foreach( var pair in sDic){
            if(pair.Value != 0){
                return false;
            }
           }

        return true;
    }
}
