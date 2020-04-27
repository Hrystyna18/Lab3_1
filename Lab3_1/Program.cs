
using System;
class stringtest
{
    static void Main()
    {
        string[] strs;
        bool doubLetter = false;
        Console.WriteLine("введiть рядок : ");
        string s = Console.ReadLine();
        strs = s.Split(null);
        Console.WriteLine("к-сть слiв : " + s.Length);
        for (int j = 0; j < strs.Length; j++)
            if (strs[j].Length > 1)
                for (int i = 1; i < strs[j].Length; i++)
                    if (strs[j][i] == strs[j][i - 1])
                    {
                        Console.WriteLine("слово з подвоєнням : " + strs[j]);
                        strs[j] = null;
                        doubLetter = true;
                        break;
                    }
        if (!doubLetter) Console.WriteLine("немає слiв з подвоєнням");
        foreach (string word in strs) Console.Write(word + " ");
        Console.WriteLine();
    }
}
