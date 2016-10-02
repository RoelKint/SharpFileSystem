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
                
                if (s.Contains("cd"))
                {
                    Console.WriteLine("GaNaar");
                    HetFileSystem.cd(s);
                }
                if (s.Contains("pwd"))
                {
                    Console.WriteLine("padnaam");
                    HetFileSystem.pwd();
                }
                if (s.Contains("mkdir"))
                {
                    Console.WriteLine("maak een dir");
                    
                } else if (s.Contains("dir"))
                {
                    Console.WriteLine("MapInhoud");
                    HetFileSystem.dir();
                }
            } while (s != null);
            Console.WriteLine("---");
        }
    }
}
