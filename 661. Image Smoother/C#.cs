/*
 * @lc app=leetcode id=661 lang=csharp
 *
 * [661] Image Smoother
 */

// @lc code=start
public class Solution {
    private class AvgCalc {
        private int count, sum;

        public AvgCalc() {
            count = 0;
            sum = 0;
        }

        public void Add(int num) {
            sum += num;
            count++;
        }

        public int Calculate() {
            return sum / count;
        }
    }

    public int[][] ImageSmoother(int[][] img) {
        int[][] result = new int[img.Length][];
        for (int i = 0; i < img.Length; i++) {
            result[i] = new int[img[i].Length];
            for (int j = 0; j < img[i].Length; j++) {
                AvgCalc avg = new();
                for (int x = i - 1; x <= i + 1; x++) {
                    for (int y = j - 1; y <= j + 1; y++) {
                        if (x >= 0 && x < img.Length && y >= 0 && y < img[x].Length) {
                            avg.Add(img[x][y]);
                        }
                    }
                }
                result[i][j] = avg.Calculate();
            }
        }
        return result;
    }
}
// @lc code=end

