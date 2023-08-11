public class TopDownSolution {
    private int[] coins;
    private int[,] memo;
    
    public int Change(int amount, int[] coins) {
        this.coins = coins;
        this.memo = new int[coins.Length, amount + 1];
        for (int i = 0; i < coins.Length; i++) {
            for (int j = 0; j <= amount; j++) {
                memo[i,j] = -1;
            }
        }
        return GetWays(0, amount);
    }

    private int GetWays(int cIndex, int amount) {
        if (amount < 0) return 0;
        if (amount == 0) return 1;
        if (cIndex >= coins.Length) return 0;
        if (memo[cIndex, amount] > -1) return memo[cIndex, amount];
        return memo[cIndex, amount] = GetWays(cIndex, amount - coins[cIndex]) + GetWays(cIndex + 1, amount);
    }
}

public class BottomUpSolution {
    public int Change(int amount, int[] coins) {
        int[] dp = new int[amount + 1];
        dp[0] = 1;
        for (int i = 0; i < coins.Length; i++) {
            for (int j = coins[i]; j <= amount; j++) {
                dp[j] += dp[j - coins[i]];
            }
        }
        return dp[amount];
    }
}