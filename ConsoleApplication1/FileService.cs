using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class FileService
    {
        public void WriteCurrentTime()
        {

            using (var streamWriter = new StreamWriter("CurrentTime.txt", true))
            {
                streamWriter.WriteLine(DateTime.Now.ToString());

                streamWriter.Close();
            }


        }
    }
}
