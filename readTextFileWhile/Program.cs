using System;

namespace readTextFileWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Values.txt");

            string line = "";

            while(line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close();
                    Console.ReadLine();



        }
    }
}


///a stream reader works like a straw and sucks in data
/// null value means that it has unknown value
/// while iteration while continue to execute until
/// becomes false
/// each value of other ta bis retrieved using stream line method
/// failure to close file can leave reference to use file