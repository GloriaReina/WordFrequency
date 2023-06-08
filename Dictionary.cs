class WordFrequencyDictionary
{
    //create a public property for holding a dictionary of words
    public Dictionary<string, int> wordFreq { get; set; } = new Dictionary<string, int>();


//method that takes an array as parameter and check if each word is found as a key in the dictionary wordFreq
    public void CountWords(string[] wordArray)
    {
        foreach (string word in wordArray)
        {
            if (wordFreq.ContainsKey(word))
            {
                // (true)increments the value by 1 
                wordFreq[word] += 1;
            }
            else 
            {
                //(false) Add key-value pairs to the dictionary 
                wordFreq[word] = 1;
            }
        }
    }

    public void PrintFrequencies()
    {
        foreach (var kvpair in wordFreq)
        {
            Console.WriteLine($"{kvpair.Key}: {kvpair.Value}");
        }
    }
}