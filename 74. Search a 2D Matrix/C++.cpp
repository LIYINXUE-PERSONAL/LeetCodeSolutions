class Solution {
public:
    bool searchMatrix(vector<vector<int>>& matrix, int target) {
        int m = matrix.size() - 1;
        int n = matrix[0].size() - 1;
        int start = 0;
        int end = m;
        int mid = 0;
        while (start <= end) {
            mid = start + (end - start) / 2;
            if (matrix[mid][0] == target) return true;
            if (matrix[mid][0] < target) {
                if (matrix[mid][n] >= target)
                    break;
                else start = mid + 1;
            } 
            else end = mid - 1;
        }
        int x = mid;
        start = 0;
        end = n;
        while (start <= end) {
            mid = start + (end - start) / 2;
            if (matrix[x][mid] == target) return true;
            if (matrix[x][mid] < target) start = mid + 1;
            else end = mid - 1;
        }
        return false;
    }
};