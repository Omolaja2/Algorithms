namespace Alogrithm;

public class Alogrithms
{
    public static List<int> GetVowelPositions(string s)
    {
        char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
        List<int> vowelsPosition = new List<int>();

        for (int i = 0; i < s.Length; i++)
        {
            foreach (char vowel in vowels)
            {
                if (s[i] == vowel)
                {
                    vowelsPosition.Add(i);
                }
            }
        }

        return vowelsPosition;
    }

    public static string ShiftLetters(string inputString)
    {
        char[] chars = new char[inputString.Length];

        for (int i = 0; i < inputString.Length; i++)
        {
            char theCharacters = inputString[i];

            if (theCharacters >= 'a' && theCharacters <= 'z')
            {
                chars[i] = (theCharacters == 'z') ? 'a' : (char)(theCharacters + 1);
            }
            else if (theCharacters >= 'A' && theCharacters <= 'Z')
            {
                chars[i] = (theCharacters == 'Z') ? 'A' : (char)(theCharacters + 1);
            }
            else
            {
                chars[i] = theCharacters;
            }
        }
        return new string(inputString);
    }

    public static string TransformCase(string inputString)
    {
        char[] theLetters = new char[inputString.Length];

        for (int g = 0; g < inputString.Length; g++)
        {
            char theCharacters = inputString[g];

            if (theCharacters >= 'a' && theCharacters <= 'z')
            {
                theLetters[g] = (theCharacters == 'z') ? 'a' : (char)(theCharacters - 32);
            }
            else if (theCharacters >= 'A' && theCharacters <= 'Z')
            {
                theLetters[g] = (theCharacters == 'Z') ? 'A' : (char)(theCharacters + 32);
            }
            else
            {
                theLetters[g] = theCharacters;
            }
        }
        return new string(theLetters);
    }


    public static string ReplaceCharacter(string str, char c1, char c2)
    {
        List<char> result = new List<char>();

        foreach (char ch in str)
        {
            if (ch == c1)
            {
                result.Add(c2);
            }

            else
            {
                result.Add(ch);
            }
        }

        return new string(result.ToArray());
    }

    public static string SwapPairs(string s)
    {

        char[] arr = new char[s.Length];

        for (int i = 0; i < s.Length; i++)
            if (i % 2 == 0)
            {
                if (i + 1 >= s.Length)
                {
                    arr[i] = s[i];
                }
                else
                {
                    arr[i] = s[i + 1];
                }

            }
            else
            {
                arr[i] = s[i - 1];
            }

        return new string(arr);
    }
}














