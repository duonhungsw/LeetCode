public class Solution {
    public int Compress(char[] chars) {
        int n = chars.Length;
        int writeIndex = 0;
        int readIndex = 0; 
        
        while (readIndex < n) {
            char currentChar = chars[readIndex];
            int count = 0;
            
            while (readIndex < n && chars[readIndex] == currentChar) {
                readIndex++;
                count++;
            }
            
            chars[writeIndex++] = currentChar;
            
            if (count > 1) {
                foreach (char c in count.ToString()) {
                    chars[writeIndex++] = c;
                }
            }
        }
        
        return writeIndex; 
    }
}
