public class Solution {
    private int[] sortedNums;
    
    public int MinimizeMax(int[] nums, int p) {
        this.sortedNums = nums;
        Array.Sort(sortedNums);

        int min = 0, max = nums[^1] - nums[0];
        while (min < max) {
            int diff = (min + max) / 2;
            if (PairsWithMaxDiff(diff) >= p) {
                max = diff;
            }
            else {
                min = diff + 1;
            }
        }
        return min;
    }

    private int PairsWithMaxDiff(int diff) {
        int count = 0;
        for (int i = 0; i < sortedNums.Length - 1; i++) {
            if (sortedNums[i + 1] - sortedNums[i] <= diff) {
                count++;
                i++;
            }
        }
        return count;
    }
}