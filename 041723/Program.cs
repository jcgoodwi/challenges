using System.Text.RegularExpressions;

public class capitals
{
    public static int[] IndexOfCapitals(string word)
    {
        Regex.Replace(word, "[^a-zA-Z]+", "");
        char[] carray = word.ToCharArray();
        string lower = word.ToLower();
        char[] lowarray = lower.ToCharArray();
        List<int> indexing = new List<int>();
        for (int i = 0; i < carray.Length; i++)
        {
            if (carray[i] != lowarray[i])
            {
                indexing.Add(i);
            }
        }
        int[] capitalStuff = indexing.ToArray();
        return capitalStuff;
    }
    public static void Main()
    {
        string word = Console.ReadLine();
        int[] array = IndexOfCapitals(word);
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(",");
            }
        }
        Console.Write("]");
    }
}
