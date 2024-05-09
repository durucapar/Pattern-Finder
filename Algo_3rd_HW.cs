using System;

namespace WordWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] search_1, words1, words2;
            bool flag1, flag2;
            string text1, search1, input1, input2;
            int index_comma, index_dot, index_1, index_2, index_s1, index_s2, count = 0;

            do
            {
                Console.WriteLine("Please, enter your text.");
                input1 = Console.ReadLine();

                index_comma = input1.IndexOf(",");
                index_dot = input1.IndexOf(".");

                if (index_comma == -1 && index_dot == -1)
                {
                    flag1 = false;
                    Console.Clear();
                }
                else
                {
                    flag1 = true;
                }

            } while (flag1 == false);

            while (true)
            {

                do
                {
                    Console.WriteLine("Please, enter your search text.");
                    input2 = Console.ReadLine();
                    Console.WriteLine(" ");

                    index_1 = input2.IndexOf("-");
                    index_2 = input2.IndexOf("*");

                    if (index_1 == -1 && index_2 == -1)
                    {

                        Console.Clear();
                        Console.WriteLine(input1);
                        flag2 = false;
                    }
                    else
                    {
                        flag2 = true;
                    }

                } while (flag2 == false);

                input1 = input1.Replace(',', ' ').Replace('.', ' ');
                text1 = input1.ToLower();
                words1 = text1.Split(" ");
                words2 = input1.Split();

                index_s1 = input2.IndexOf('-');
                index_s2 = input2.IndexOf('*');


                if (-1 < index_s1)
                {
                    input2 = input2.Replace('-', ' ');
                    for (int b = 0; b < input2.Length; b++)
                    {
                        if (input2[b] == ' ')
                        {
                            count++;
                        }
                    }

                    if (input2.Length == count)
                    {
                        for (int m = 0; m < words1.Length; m++)
                        {
                            if (words1[m].Length == input2.Length)
                            {
                                Console.WriteLine(words2[m]);
                            }


                        }
                    }
                    else
                    {
                        search1 = input2.ToLower();
                        search_1 = search1.Split(' ');

                        for (int i = 0; i < words1.Length; i++)
                        {
                            if (words1[i].Length == input2.Length)
                            {
                                for (int j = 0; j < search_1.Length; j++)
                                {                                    
                                    if (words1[i].IndexOf(search_1[j]) > 0)
                                    {
                                        count++;
                                    }
                                    else continue;
                                }

                                if (1 <= count)
                                {
                                    Console.WriteLine(words2[i]);
                                    count = 0;
                                }
                                else
                                {
                                    count = 0;
                                }
                            }


                        }

                    }
                }
                else if (-1 < index_s2)
                {

                    if (input2 == "*")
                    {
                        for (int m = 0; m < words1.Length; m++)
                        {
                            Console.WriteLine(words2[m]);
                        }
                    }
                    else
                    {
                        input2 = input2.Replace('*', ' ');
                        search1 = input2.ToLower();
                        search_1 = search1.Split(' ');

                        for (int i = 0; i < words1.Length; i++)
                        {

                            for (int j = 0; j < search_1.Length; j++)
                            {
                                if (words1[i].IndexOf(search_1[j]) > 0) count++;
                              
                            }

                            if (1 <= count)
                            {
                                Console.WriteLine(words2[i]);
                                count = 0;
                            }
                            else
                            {
                                count = 0;
                            }

                        }
                    }
                }
                Console.ReadLine();
            }

        }
    }
}


