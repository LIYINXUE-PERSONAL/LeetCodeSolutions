class Solution:
    def wordBreak(self, s: str, wordDict: List[str]) -> bool:
        dp = [None for _ in s] + [True]
        wordDict = set(wordDict)

        for start in range(len(s)-1, -1, -1):
            for end in range(start, len(s)):
                if s[start:end+1] in wordDict and dp[end+1] is True:
                    dp[start] = True
                    break

        return dp[0]

