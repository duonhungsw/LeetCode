public class Solution {
     public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int count = 0;
        int length = flowerbed.Length;

        for (int i = 0; i < length; i++) {
            if (flowerbed[i] == 0) {
                // Check if the previous and next plots are empty or out of bounds
                bool isPrevEmpty = (i == 0) || (flowerbed[i - 1] == 0);
                bool isNextEmpty = (i == length - 1) || (flowerbed[i + 1] == 0);

                if (isPrevEmpty && isNextEmpty) {
                    flowerbed[i] = 1; // Plant a flower here
                    count++;
                    if (count >= n) {
                        return true; // We can plant all required flowers
                    }
                }
            }
        }

        return count >= n; // Return true if we could plant all flowers
    }
}