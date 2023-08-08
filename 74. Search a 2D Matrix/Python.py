class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        self.rowNum, self.colNum = len(matrix), len(matrix[0])
        l, r = 0, self.rowNum * self.colNum-1

        while l <= r:
            mid = (l+r)//2
            row, col = self.get2DIndexes(mid)

            if matrix[row][col] == target:
                return True

            if matrix[row][col] > target:
                r = mid-1
            else:
                l = mid + 1

        return False

    def get2DIndexes(self, index):
        return divmod(index, self.colNum)
