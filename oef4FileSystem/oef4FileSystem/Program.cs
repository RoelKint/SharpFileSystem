using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oef4FileSystem.Model;

namespace oef4FileSystem
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            FileSystem HetFileSystem = new FileSystem();
            string s;
            int ctr = 0;
            HetFileSystem.dir();
            do
            {
                ctr++;
                s = Console.ReadLine();
                Console.WriteLine("jow");
            } while (s != null);
            Console.WriteLine("---");
        }
    }
}
