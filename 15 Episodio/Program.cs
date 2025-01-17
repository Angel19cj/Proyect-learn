using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _15_episodio
{
    class Program
    {
 
        static void Main(string[] args)
        {

            WebClient client = new WebClient();
            string reply = client.DownloadString("Http://msdn.microsoft.com");

            Console.WriteLine(reply);

            File.WriteAllText(@"C:\Users\Zahid\Documents\Visual Studio 2022\Projects\BTaborCodingFundamentals\15_episodio\WriteText.txt", reply);

            Console.ReadLine();
        }
    }
}
