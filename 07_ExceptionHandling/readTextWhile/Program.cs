using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readTextWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //beginning of try-catch block
            //we are 'wrapping' the application in a try-catch block to handle exceptions
            try
            {

                //the initial application started here
                //it would read text from a file called value.txt and write it to the console
                //the application was modified later: value.txt filename was changed to value1.txt(see Sol Explorer)
                //file could not be read, so a try-catch block was added to show the error

                StreamReader myReader = new StreamReader("value.txt");
                string line = " ";

                while (line != null)
                {
                    line = myReader.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                myReader.Close();
            }

            ////catch part of try-catch block

            catch (DirectoryNotFoundException e)
            {
                //if the exception is a DNF one, suggest a possible remedy
                Console.WriteLine("Couldn't find the directory. Are you sure it exists?");
            }

            catch (FileNotFoundException e)
            {
                //if the exception is a DNF one, suggest a possible remedy
                Console.WriteLine("Couldn't find the file. Are you sure you're looking in the right place?");
            }

            catch (Exception e)
            {
                //we check what the exception is, catch it and write it to the screen
                //we only do this after checking specific cases as per above
                Console.WriteLine("Something didn't quite work correctly: {0}", e.Message);
            }

            finally
            {
                //Perform any cleanup to roll back the data or close connections to files, database, network etc

            }

            Console.ReadLine();

        }
    }
}
