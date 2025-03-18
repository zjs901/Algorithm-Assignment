using System;

namespace Application 
{
    
    class main 
    {
        static void Main(string[] args) 
        {
            //Search();
            DataCompile();
        }

        static void DataCompile()
        {
            string data;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("Share_1_data.txt");
                data = reader.ReadLine();

                while (data != null)
                {
                    Console.WriteLine(data);
                    data = reader.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        static void Search(int[] array)
        {
            Console.WriteLine("Searching...");
        }
    }
}