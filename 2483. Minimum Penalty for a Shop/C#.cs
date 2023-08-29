public class Solution {
    public int BestClosingTime(string customers) {
        int minPen = 0, minIndex = 0, curPen = 0;
        for (int i = 0; i < customers.Length; i++) {
            if (customers[i] == 'Y') curPen--;
            else curPen++;
            if (curPen < minPen) {
                minIndex = i + 1;
                minPen = curPen;
            }
        }
        return minIndex;
    }
}