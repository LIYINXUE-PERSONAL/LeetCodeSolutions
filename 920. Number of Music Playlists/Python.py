class Solution:
    MOD = 1_000_000_007
    def numMusicPlaylists(self, n: int, goal: int, k: int) -> int:
        # dp[(songNum, playlistLength)]: how many playlists can be created given songNum, playlistLength
        self.dp = defaultdict(int)
        self.k = k

        return self.helper(n, goal)

    def helper(self, songNum, playlistLength):
        # termination cases
        if songNum == 0 and playlistLength == 0:
            return 1
        if songNum == 0 or playlistLength == 0:
            return 0
        if (songNum, playlistLength) in self.dp:
            return self.dp[(songNum, playlistLength)]
        
        # add a new song
        self.dp[(songNum, playlistLength)] += self.helper(songNum-1, playlistLength-1) * songNum % self.MOD
        # add an old song
        self.dp[(songNum, playlistLength)] += self.helper(songNum, playlistLength-1) * max(songNum-self.k, 0) % self.MOD

        self.dp[(songNum, playlistLength)] %= self.MOD
        return self.dp[(songNum, playlistLength)]
