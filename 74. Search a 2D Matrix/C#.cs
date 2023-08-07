public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int top = 0, bottom = matrix.Length - 1;
        int row = 0;
        while (top <= bottom) {
            row = (top + bottom) / 2;
            if (matrix[row][0] == target) return true;
            if (matrix[row][0] < target) {
                if (matrix[row][^1] == target) return true;
                if (matrix[row][^1] > target) {
                    break;
                }
                top = row + 1;
            }
            else bottom = row - 1;
        }
        int left = 0, right = matrix[row].Length - 1;
        while (left <= right) {
            int mid = (left + right) / 2;
            if (matrix[row][mid] == target) return true;
            if (matrix[row][mid] > target) right = mid - 1;
            else left = mid + 1;
        }
        return false;
    }
}