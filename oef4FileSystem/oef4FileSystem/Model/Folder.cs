using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef4FileSystem.Model
{
    public class Folder : File
    {
        private List<File> _Files = new List<File>();

        public List<File> Files
        {
            get { return _Files; }
            set { _Files = value; }
        }

        public Folder(string name, Folder parent) : base(name)
        {
            Parent = parent;
            Files = new List<File>();
            //Files.Add(new Folder("foldeir", this));
            Files.Add(new TextFile("file5"));
            Files.Add(new TextFile("file5"));
            Files.Add(new TextFile("file5"));
            Files.Add(new TextFile("file66"));
            Files.Add(new TextFile("file65"));
            Files.Add(new TextFile("file32"));

            if (name == "folder")
            {
                Files.Add(new TextFile("CONTROLEERFILE"));
            }

        }
        //alleen voor de root dir.
        public Folder(string name) : base(name)
        {
        }
        public TextFile GetFile(string name)
        {
            TextFile fileke = new TextFile("lollie");
            return fileke;
        }
        public int CreateTextFile(string name)
        {
            if (name != null && name != "")
            {
                foreach (TextFile a in Files)
                {
                    if (a.Name == name)
                    {
                        throw new FileSystemException("De Naam bestaat al");
                    }
                    Files.Add(new TextFile(name));
                    return 1;
                }
            }
            throw new FileSystemException("Ge moet wel een waarde ingeven eh");
        }
        public int CreateFolder(string name)
        {
            if (name != null && name != "")
            {
                foreach (Folder a in Files)
                {
                    if (a.Name == name)
                    {
                        throw new FileSystemException("De Naam bestaat al");
                    }
                    Files.Add(new Folder(name));
                    return 1;
                }
            }
            throw new FileSystemException("Ge moet wel een waarde ingeven eh");
        }

        public void PrintList()
        {
            foreach (Folder a in Files)
            {
                Console.WriteLine(a.Name + "/");
            }
            foreach (TextFile a in Files)
            {
                Console.WriteLine(a.Name + "/");
            }
        }

        //moet nog gefixt worden
        public void PrintTree()
        {

        }
    }
}
