using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fraze = Console.ReadLine();
            string[] stringArray = fraze.Split();
            string rusulString = "";
            foreach (string s in stringArray)
            {
                rusulString += s.Substring(0, 1).ToLower() + s.Substring(1) + ' ';
                
            }
            
            rusulString = rusulString.Replace(" ","");
            Console.WriteLine(rusulString);
            char[] letters = rusulString.ToArray();
            int len = letters.Length;
            bool a = true;
            
            {
                for (int i = 0; i < len / 2; ++i)
                a = (letters[i] == letters[len - i - 1]);
                Console.WriteLine("Фраза является палиндромом");
                a = false;
                Console.WriteLine("Фраза является не палиндромом");
            }
           
            Console.ReadKey();
        }

    }
}

//bool check = true;
//Console.WriteLine(check ? "Checked" : "Not checked");  // output: Checked

//Console.WriteLine(false ? "Checked" : "Not checked");  // output: Not checked
//А роза упала на лапу Азора

//for (int i = 0; i < len / 2; ++i)
//{
//    if (letters[i] == letters[len - i - 1])
//        Console.WriteLine("Фраза является палиндромом");
//    else
//        Console.WriteLine("Фраза не является палиндромом");
//}
//Console.ReadKey();