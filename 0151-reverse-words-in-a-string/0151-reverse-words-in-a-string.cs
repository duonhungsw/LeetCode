public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        string result = "";
        for(int i = words.Length - 1; i >= 0 ; i--){
            result += words[i];
            if(i > 0) result += " ";
        }
        return result;
    }
}