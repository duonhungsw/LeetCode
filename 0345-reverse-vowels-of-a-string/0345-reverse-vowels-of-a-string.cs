public class Solution {
    public string ReverseVowels(string s) {
        HashSet<char> vowels = new HashSet<char>{'u','e','o','a','i','U','E','O','A','I'};
        char[] chars = s.ToCharArray();
        int left = 0, right = s.Length - 1;

        while(left < right)
        {
            while(left < right && !vowels.Contains(chars[left]))
            {
                left++;
            }

            while (left < right && !vowels.Contains(chars[right]))
            {
                right--;
            }

            if (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }
        }
        return new string(chars);
    }
}