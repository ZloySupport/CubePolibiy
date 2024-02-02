using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Shiferina
{
    
    public class Crypto
    {
        public string[] Encrypt(string Text)
        {
            char[,] table = new char[21, 21];
            Random rnd = new Random();
            string kkey = "";
            string Out = "";
            for (int i = 1; i < 21; i++)
            {
            tut:
                char bb = Convert.ToChar(rnd.Next('A', 'z'));
                for (int b = 1; b < 21; b++)
                {
                    if (table[0, b] == bb || table[b, 0] == b)
                    {
                        goto tut;
                    }
                }
                table[0, i] = bb;
                table[i, 0] = bb;
                kkey += bb;
            }
            //for (int i = 1; i < 21; i++)
            //{
            //    Kkey += table[0, i];
            //}
            char addchar = ' ';
            char addRus = 'А';
            for (int i = 1; i < 21; i++)
            {
                for (int k = 1; k < 21; k++)
                {
                    if (table[i, k] == 0)
                    {
                        table[i, k] = addchar;
                        table[i, k + 1] = addRus;
                        try
                        {
                            addchar = Convert.ToChar(Convert.ToInt32(addchar) + 1);
                        }
                        catch
                        {
                        }
                        try
                        {
                            addRus = Convert.ToChar(Convert.ToInt32(addRus) + 1);
                        }
                        catch { }
                    }
                }
            }
            //for(int i = 0; i < 21; i++)
            //{
            //    for(int j  = 0; j < 21; j++)
            //    {
            //        OutText.Text += table[i, j];
            //    }
            //    OutText.Text += "            ";
            //}
            
            char[] firsttxt = Text.ToCharArray();
            foreach (char c in firsttxt)
            {
                bool search = false;
                while (true)
                {
                    try
                    {
                        for (int i = 1; i < 21; i++)
                        {
                            for (int k = 1; k < 21; k++)
                            {
                                if (table[i, k] == c)
                                {
                                    Out += table[0, k];
                                    Out += table[i, 0];
                                    search = true;
                                }
                            }
                        }
                        if (search == false) { Out = "Ошибка!"; }
                        break;
                    }
                    catch
                    {
                        Out = "Ошибка!";
                    }
                }
            }
            string[] str = new string[2] { Out, kkey };
            
            return str;
        }
        public string Decrypt(string Text, string Key)
        {
            char[,] table = new char[21, 21];
            char[] key = Key.ToCharArray();
            string Out = "";
            int ji = 0;
            if (key.Length != 20)
            {
                Out = "Не правельный формат ключа";
                return Out;
            }
            for (int i = 1; i < 21; i++)
            {
                table[0, i] = Convert.ToChar(key[ji]);
                table[i, 0] = Convert.ToChar(key[ji]);
                ji++;
            }
            char addchar = ' ';
            char addRus = 'А';
            for (int i = 1; i < 21; i++)
            {
                for (int k = 1; k < 21; k++)
                {
                    if (table[i, k] == 0)
                    {
                        table[i, k] = addchar;
                        table[i, k + 1] = addRus;
                        try
                        {
                            addchar = Convert.ToChar(Convert.ToInt32(addchar) + 1);
                        }
                        catch
                        {
                        }
                        try
                        {
                            addRus = Convert.ToChar(Convert.ToInt32(addRus) + 1);
                        }
                        catch { }
                    }
                }
            }
            //for (int i = 0; i < 21; i++)
            //{
            //    for (int j = 0; j < 21; j++)
            //    {
            //        OutText.Text += table[i, j];
            //    }
            //    OutText.Text += "       ";
            //}
            
            char[] text = Text.ToCharArray();
            for (int j = 0; j < Text.Length; j += 2)
            {
                int ii = 0;
                int jj = 0;
                try
                {
                    for (int i = 1; i < 21; i++)
                    {
                        if (Text[j] == table[0, i])
                        {
                            ii = i;
                            break;
                        }
                    }
                    for (int i = 1; i < 21; i++)
                    {
                        if (Text[j + 1] == table[i, 0])
                        {
                            jj = i;
                            break;
                        }
                    }
                    if (jj != 0 && ii != 0)
                    {
                        Out += table[jj, ii];
                    }
                    else
                    {
                        Out = "Ошибка! Код 12";
                    }
                }
                catch
                {
                    Out = "Ошибка!";
                }
            }
            return Out;
        }
    }
}
