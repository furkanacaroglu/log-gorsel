using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matris = new char[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        matris[i, j] = '*';
                    }
                    else
                    {
                        matris[i, j] = '=';
                    }
                }
            }
            

            
            int x = 5; 
            int y = 5;  
            char yon = 'N'; 
            matris[x, y] = '^'; 


            while (true)
            {

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(matris[i, j]);
                    }
                    Console.WriteLine();
                }


                Console.WriteLine("Lütfen bir komut giriniz: ");
                string komut = Console.ReadLine();


                switch (komut)
                {
                    case "r":

                        if (yon == 'N')
                            yon = 'E';
                        else if (yon == 'E')
                            yon = 'S';
                        else if (yon == 'S')
                            yon = 'W';
                        else if (yon == 'W')
                            yon = 'N';

                        if (yon == 'N')
                            matris[x, y] = '^';
                        else if (yon == 'E')
                            matris[x, y] = '>';
                        else if (yon == 'S')
                            matris[x, y] = 'v';
                        else if (yon == 'W')
                            matris[x, y] = '<';
                        break;
                    case "l":

                        if (yon == 'N')
                            yon = 'W';
                        else if (yon == 'W')
                            yon = 'S';
                        else if (yon == 'S')
                            yon = 'E';
                        else if (yon == 'E')
                            yon = 'N';

                        if (yon == 'N')
                            matris[x, y] = '^';
                        else if (yon == 'E')
                            matris[x, y] = '>';
                        else if (yon == 'S')
                            matris[x, y] = 'v';
                        else if (yon == 'W')
                            matris[x, y] = '<';
                        break;
                    case "f":
                        

                        matris[x, y] = (x + y) % 2 == 0 ? '*' : '=';

                        if (yon == 'N')
                            x--;
                        else if (yon == 'E')
                            y++;
                        else if (yon == 'S')
                            x++;
                        else if (yon == 'W')
                            y--;

                        if (x < 0 || x > 9 || y < 0 || y > 9)
                        {

                            Console.WriteLine("Board sınırlarını aştınız!");
                            return;
                        }

                        matris[x, y] = yon == 'N' ? '^' : yon == 'E' ? '>' : yon == 'S' ? 'v' : '<';
                        break;
                    default:

                        Console.WriteLine("Geçersiz komut!");
                        break;
                }
            }
        }
    }
}
