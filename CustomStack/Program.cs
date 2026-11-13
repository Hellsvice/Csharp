using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.IO.Pipes;

namespace _2024_07_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Olvassunk be egy .cs fájlt, döntsük, el, hogy helyesen van zárójelezve
            // 1. Lépés: szavak, space-ek, \n - ek kisztedése -> csak a zárójelek maradjanak meg
            string path = "Program.cs";

            string text = File.ReadAllText(path);

            // 1. Lépés -> 1. Megoldás
            string brackets = "()[]{}";
            string onlyBrackets = "";
            foreach (char c in text)
            {
                if (brackets.Contains(c))
                {
                    onlyBrackets += c;
                }
            }
            Console.WriteLine($"The brackets: {onlyBrackets}");


            // 1. Lépés -> 2. Megoldás
            string onlyBrackets2 = Regex.Replace(text, "[^\\(\\)\\[\\]\\{\\}]", "");


            Console.WriteLine($"The brackets2: {onlyBrackets2}");

            bool correct = AreBracketsBalanced(onlyBrackets);
            if (correct)
            {
                Console.WriteLine("Helyes a zárójelezés");
            }
            else
            {
                Console.WriteLine("Nem helyes a zárójelezés");
            }

            Console.ReadLine();

        }

        private static bool AreBracketsBalanced(string onlyBrackets)
        {
            char[] chars = onlyBrackets.ToCharArray();

            // HF: írdd át ezt a metódust, hogy a Stack (beépített) - et használja
            // HF: írdd át ezt a metódust, hogy a CustomStackChar - t használja
            CustomStack<char> stack = new CustomStack<char>(1000);

            for (int i = 0; i < chars.Length; i++)
            {
                // Ha az aktuális karakter nyitó zárójel
                if (chars[i] == '(' || chars[i] == '[' || chars[i] == '{')
                {
                    stack.Push(chars[i]);
                }

                // Ha az aktuális karakter csukó zárójel
                if (chars[i] == ')' || chars[i] == ']' || chars[i] == '}')
                {
                    // Ha a stack üres, akkor nem helyes a zárójelezés
                    if (stack.isEmpty())
                    {
                        return false;
                    }

                    char ch2 = stack.Pop();

                    // Ha nem egyezik az aktuális zárójel pár, akkor hibás a zárójelezés
                    if (!isMatchingPair(ch2, chars[i]))
                    {
                        return false;
                    }
                }
            }


            // Ha maradt fel nem dolgozott zárójel, akkor hibás a zárójelezés
            //if (stack.Count != 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}

            return stack.Count == 0;

        }

        private static bool isMatchingPair(char c1, char c2) 
        {
            if(c1 == '(' && c2 == ')')
            {
                return true;
            }
            else if (c1 == '[' && c2 == ']')
            {
                return true;
            }
            else if (c1 == '{' && c2 == '}')
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}
