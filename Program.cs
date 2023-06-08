using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;



//You might want to research the Dictionary type in C#, including the ContainsKey() method.


class Program
{
    static void Main()
    {
        string s1 = " Look again at that dot. That's here. That's home. That's us. On it everyone you love, everyone you know, everyone you ever heard of, every human being who ever was, lived out their lives. The aggregate of our joy and suffering, thousands of confident religions, ideologies, and economic doctrines, every hunter and forager, every hero and coward, every creator and destroyer of civilization, every king and peasant, every young couple in love, every mother and father, hopeful child, inventor and explorer, every teacher of morals, every corrupt politician, every 'superstar,' every 'supreme leader,' every saint and sinner in the history of our species lived there--on a mote of dust suspended in a sunbeam.The Earth is a very small stage in a vast cosmic arena. Think of the rivers of blood spilled by all those generals and emperors so that, in glory and triumph, they could become the momentary masters of a fraction of a dot. Think of the endless cruelties visited by the inhabitants of one corner of this pixel on the scarcely distinguishable inhabitants of some other corner, how frequent their misunderstandings, how eager they are to kill one another, how fervent their hatreds.Our posturings, our imagined self-importance, the delusion that we have some privileged position in the Universe, are challenged by this point of pale light. Our planet is a lonely speck in the great enveloping cosmic dark. In our obscurity, in all this vastness, there is no hint that help will come from elsewhere to save us from ourselves.The Earth is the only world known so far to harbor life. There is nowhere else, at least in the near future, to which our species could migrate. Visit, yes. Settle, not yet. Like it or not, for the moment the Earth is where we make our stand.It has been said that astronomy is a humbling and character-building experience. There is perhaps no better demonstration of the folly of human conceits than this distant image of our tiny world. To me, it underscores our responsibility to deal more kindly with one another, and to preserve and cherish the pale blue dot, the only home we've ever known.- Carl Sagan";

        //remove any characters/punctuation that are not alphabets or spaces from the text.
        s1 = Regex.Replace(s1, "[^A-Za-z ]", "");

        //Splits the text into an array of words by splitting it at each occurrence of a space character
        string[] stringArray = s1.Split(' ');

         // Create a new dictionary
        WordFrequencyDictionary myDict = new WordFrequencyDictionary();//when create, has nested property wordFreq
        myDict.CountWords(stringArray);
        myDict.PrintFrequencies();

                         //un comment for alternate code option--in here did not create dictionary class
    // Dictionary<string, int> wordCounter = new Dictionary<string, int>(); 
       
    //    foreach (var item in stringArray)
    //    {
    //     if(wordCounter.ContainsKey(item)){
    //         wordCounter[item] += 1; 
    //     }
    //     else
    //     {
    //         wordCounter[item] = 1;
    //     }
    //    }
   
//     foreach (KeyValuePair<string,int> item in wordCounter)
// {
//     Console.WriteLine($"{item.Key}: {item.Value}");
// }
        // code to check outpu
    //    List<string> howManyOf = stringArray.Where( x => x == "of" ).ToList();

    // Console.WriteLine(howManyOf.Count);
        
       


    }
}





















// class Program
// {
//     static void Main()
//     {
//         // Create a new dictionary
//         Dictionary<string, int> ages = new Dictionary<string, int>();

//         // Add key-value pairs to the dictionary
//         ages["John"] = 25;
//         ages["Alice"] = 30;
//         ages["Bob"] = 40;

//         // Access values by key
//         int johnAge = ages["John"];
//         Console.WriteLine("John's age: " + johnAge);

//         // Check if a key exists
//         bool hasAlice = ages.ContainsKey("Alice");
//         Console.WriteLine("Has Alice? " + hasAlice);

//         // Get the number of key-value pairs
//         int count = ages.Count;
//         Console.WriteLine("Dictionary count: " + count);

//         // Iterate over key-value pairs
//         foreach (KeyValuePair<string, int> pair in ages)
//         {
//             Console.WriteLine(pair.Key + ": " + pair.Value);
//         }

//         // Remove a key-value pair
//         ages.Remove("Bob");

//         // Clear the dictionary
//         ages.Clear();

//         // Check if the dictionary is empty
//         bool isEmpty = ages.Count == 0;
//         Console.WriteLine("Is dictionary empty? " + isEmpty);
//     }
// }
