using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces_and_referencing_assemlies
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader myStreamReader = new StreamReader("TestFile.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached. Click Enter to display each line.
                    while ((line = myStreamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        Console.ReadLine();
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            //StreamReader just a Class name; System.IO is the hierarchy of namespace containing the StreamReader class
            //a namespace is a way to organise classes that are related, typically by features
            //the namespace is like the surname - it allows you to pinpoint the correct class you're looking for
            //if you're stuck on a class/namespace, try Ctrl + . to get possible help menu

        }
    }
}
