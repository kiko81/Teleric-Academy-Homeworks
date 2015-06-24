using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class LineNumbers
{
    static void Main(string[] args)
    {
        StreamReader streamReader = new StreamReader(@"..\..\test.txt", Encoding.ASCII);
        StreamWriter streamWriter = new StreamWriter(@"..\..\result.txt", true);

        using (streamWriter)
        {
            using (streamReader)
            {
                string line = streamReader.ReadLine();
                int counter = 0;
                while (line != null)
                {
                    counter++;
                    line = line.Insert(0, counter.ToString() + ": ");
                    streamWriter.WriteLine(line);
                    line = streamReader.ReadLine();
                }
            }

        }
    }
}
