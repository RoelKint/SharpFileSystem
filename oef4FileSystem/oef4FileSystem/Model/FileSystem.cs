using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef4FileSystem.Model
{
    public class FileSystem
    {
        private Folder _CurrentFolder;
        public Folder root { get; set; }
        public string wortel { get; set; }

        private Folder CurrentFolder
        {
            get { return _CurrentFolder; }
            set { _CurrentFolder = value; }
        }
        public FileSystem()
        {
            root = new Folder("");

            int jo = 1234;
            root.Files.Add(new Folder("folder", root));
            root.Files.Add(new Folder("folder2", root));
            root.Files.Add(new TextFile("file1"));
            Folder folder1 = (Folder)root.Files.Find(x => x.Name.Contains("folder")); ;
            folder1.Files.Add(new Folder("fildaar", folder1));

            CurrentFolder = root;
        }

        public void cd(string path)
        {
            Folder fd = CurrentFolder;
            string[] PathParts = path.Split(' ');
            if (PathParts.Length == 1)
            {
                throw new FileSystemException("Deze map bestaat niet! stop met mijn programma te doen crashen!!!");
            }
            if (PathParts[1] == "..")
            {
                CurrentFolder = CurrentFolder.Parent;
            }
            else {
                int found = 0;
                foreach (File f in CurrentFolder.Files)
                {
                    if (f.GetType() == CurrentFolder.GetType())
                    {

                        if (f.Name == PathParts[1])
                        {
                            CurrentFolder = (Folder)f;
                            found++;
                        }

                    }
                }

                if (found == 0)
                {

                    throw new FileSystemException("Deze map bestaat niet! stop met mijn programma te doen crashen!!!");

                }
            }
            pwd();

        }
        public void pwd()
        {
            string PwdString = "/";
            Folder vorige = CurrentFolder;
            while (vorige.Parent != null)
            {
                if (vorige.Name != null)
                {
                    PwdString = "/" + vorige.Name + PwdString;
                }
                vorige = vorige.Parent;
            }
            Console.WriteLine(PwdString);
        }
        public void dir()
        {
            foreach (File a in CurrentFolder.Files)
            {
                Folder b = new Folder("hey");
                TextFile c = new TextFile("yo");
                if (a.GetType() == b.GetType())
                {
                    Console.WriteLine(a.Name + "/");
                }
                if (a.GetType() == c.GetType())
                {
                    Console.WriteLine(a.Name);
                }

            }
        }
        //fuck deze functie echt
        public void tree()
        {

            Weergevenbinnenkant(CurrentFolder, "");
        }
        public void Weergevenbinnenkant(Folder Current, string indent)
        {
            foreach (File f in Current.Files)
            {
                string LangereIntent = indent + "   ";
                if (f.GetType() == Current.GetType())
                {
                    Console.WriteLine(indent + f.Name);
                    Weergevenbinnenkant((Folder)f, LangereIntent);
                }
                else
                {
                    Console.WriteLine(indent + f.Name);
                }
            }
        }

        public void mktext(string name)
        {
            string[] PathParts = name.Split(' ');
            foreach (File a in CurrentFolder.Files)
            {
                if (a.Name == PathParts[1] && a.GetType() != CurrentFolder.GetType())
                {
                    throw new FileSystemException("DUDE DEZE FILE BESTAAT AL");
                }
            }
            CurrentFolder.Files.Add(new TextFile(PathParts[1]));
        }
        public void mkdir(string name)
        {
            string[] PathParts = name.Split(' ');
            foreach (File a in CurrentFolder.Files)
            {
                if (a.Name == PathParts[1] && a.GetType() == CurrentFolder.GetType())
                {
                    throw new FileSystemException("DUDE DEZE FOLDER BESTAAT AL");
                }
            }
            CurrentFolder.Files.Add(new Folder(PathParts[1], CurrentFolder));
        }
    }
}
