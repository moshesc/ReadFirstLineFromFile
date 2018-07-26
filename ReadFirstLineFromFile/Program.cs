using System;
// Adding System IO in order to have access to file handling method such as to Exsist, Delete and cte.
using System.IO;
using System.Text;

namespace ReadFirstLineFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            ///create a string variable to store the file
           
            string fileName = @"myTest.txt";

            //Check if the file is exists, if yes then delete it.
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                //Display a message about what the program is doing
                Console.WriteLine("\n\nRead the first line from the file: \n");
                Console.WriteLine("-------------------------------------------");

                //Create the file by creating an instance of StreamWriter class and use WriteLine method in order to write 3 lines.
                using (StreamWriter filestr = File.CreateText(fileName))
                {
                    filestr.WriteLine(" test line 1");
                    filestr.WriteLine(" test line 2");
                    filestr.WriteLine(" test line 3");
                }
                //Create an instance of StreamReader to read from a file
                //The using statment also closes the StreamReader.
                using (StreamReader sr = File.OpenText(fileName))
                {//Read and display content from the file untill
                    //the end of the file is reached.
                    string s = " ";
                    Console.WriteLine("Here is the content of the file mytest.txt: ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine(" ");
                }
                //If the file exists read all the lines but display only the first line.
                Console.Write("\n the content of the first line is:  \n");
                if (File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);
                    Console.Write(lines[0]);
                }
                Console.WriteLine();
            }
            //
            catch (Exception MyExcep)
            {

                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
}
