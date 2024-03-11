
public class Task2
{
    public static void Method()
    {
        Console.Write("Enter String: ");
        string String = Console.ReadLine() ?? "";
        Dictionary<char, int> CharMapFreq = new Dictionary<char, int>();
        foreach (char Char in String)
        {

            if (char.IsLetter(Char))
            {
                if (CharMapFreq.ContainsKey(char.ToLower(Char)))
                {
                    CharMapFreq[char.ToLower(Char)]++;
                }
                else
                {
                    CharMapFreq.Add(char.ToLower(Char), 1);
                }
            }
        }

        foreach(KeyValuePair<char, int> key in CharMapFreq) {
            Console.WriteLine($"{key.Key}   ----->   {key.Value}");
        }
    }
}