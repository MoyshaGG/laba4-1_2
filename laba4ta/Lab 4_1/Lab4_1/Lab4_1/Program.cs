using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int multiply;
            int sum = 0;
            int normaldate = 0;
            string numb1, numb2;

            for (int j = 10; j < 30; j++)
            {
                string path = @"C:\Users\Cobra\Desktop\laba4ta\txtFile\" + j + ".txt";
                try
                {


                    StreamReader streamreader = new StreamReader(path);
                    numb1 = streamreader.ReadLine();
                    num1 = Convert.ToInt32(numb1);
                    Console.WriteLine("Перше число: " + numb1 , num1);
                    numb2 = streamreader.ReadLine();
                    num2 = Convert.ToInt32(numb2);
                    Console.WriteLine("Друге число:"+ numb2 , num2 );
                 
                    multiply = num1 * num2;
                    
                    Console.WriteLine("Файл: "+j+".txt:"+numb1,numb2);

                    Console.WriteLine("Множення:"+ multiply);
                    Console.WriteLine();
                    Console.WriteLine();


                    sum += multiply;
                    normaldate++;
                    streamreader.Dispose();

                }
                catch (System.IO.FileNotFoundException)
                {
                    using (StreamWriter no_file = new StreamWriter(@"C:\Users\cobra\Desktop\laba4ta\no_file.txt", false, System.Text.Encoding.Default))
                    {
                        no_file.WriteLine(j + ".txt");
                    }
                }
                catch (System.FormatException)
                {
                    using (StreamWriter bad_data = new StreamWriter(@"C:\Users\cobra\Desktop\laba4ta\bad\bad_data.txt", false, System.Text.Encoding.Default))
                    {
                        bad_data.WriteLine(j + ".txt");
                    }
                }
                catch (System.OverflowException)
                {

                    using (StreamWriter overflow = new StreamWriter(@"C:\Users\cobra\Desktop\laba4ta\bad\overflow.txt", false, System.Text.Encoding.Default))
                    {
                        overflow.WriteLine(j + ".txt");
                    }
                }

            }
            Console.WriteLine("Середнє арифметичне: ");
            Console.WriteLine(sum / (double)normaldate);
            Console.ReadKey();
        }

    }
}
