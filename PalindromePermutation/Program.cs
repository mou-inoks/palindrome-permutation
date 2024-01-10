bool IsPalindrome(string word1, string word2)
{
    bool isPalindrome = false;

    if (word1.Length != word2.Length)
        isPalindrome = false;
    else
    {
        int t = word1.Length -1;
        int v = 0;
        for (int i = 0; i < word1.Length; i++)
        {
            if (word1[i] == word2[t])
                v++;

            t -= 1;
        }

        if (v == word1.Length)
            isPalindrome = true;
        
    }

    return isPalindrome;
}

Console.Write(IsPalindrome("salim","milal"));