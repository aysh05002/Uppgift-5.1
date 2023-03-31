using System;

class program
{
    static void Main(string[] args)
    {
        string[] sträng = new string[3];
        sträng[0] = "Första raden";
        sträng[1] = "Andra raden";
        sträng[2] = "Trädje raden";

        for (int i = 0; i < sträng.Length; i++)
        {
            Console.WriteLine(sträng[i]);
            Console.WriteLine();
        }
    }
}