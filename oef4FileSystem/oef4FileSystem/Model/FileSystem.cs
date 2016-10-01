﻿using System;
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
            CurrentFolder = root;
            int jo = 1234;
            root.Files.Add(new TextFile("Al een file1"));
            root.Files.Add(new TextFile("Al een file1"));
            root.Files.Add(new TextFile("Al een file1"));
            root.Files.Add(new Folder("Al een folder1"));
            root.Files.Add(new Folder("Al een folder1"));
            root.Files.Add(new Folder("Al een folder1"));
        }

        public void cd(string path)
        {
            if(path == "..")
            {
                CurrentFolder = CurrentFolder.Parent;
            } else if(path == "/" && CurrentFolder.Parent != null)
            {
                CurrentFolder = root;
            }

            foreach(Folder a in CurrentFolder.Files)
            {
                if(a.Name == path)
                {
                    CurrentFolder = a;
                }
            }
            throw new FileSystemException("Deze map bestaat niet! stop met mijn programma te doen crashen!!!");
        }
        public void pwd()
        {
            Console.WriteLine(CurrentFolder.Name);
        }
        public void dir()
        {
            foreach(File a in CurrentFolder.Files)
            {
                Console.WriteLine(a.Name);
            }
        }
        //fuck deze functie echt
        public void tree()
        {

        }

        public void mktext(string name)
        {
            foreach(TextFile a in CurrentFolder.Files)
            {
                if(a.Name == name)
                {
                    throw new FileSystemException("DUDE DEZE FILE BESTAAT AL");
                }
            }
            CurrentFolder.Files.Add(new TextFile(name));
        }
        public void mkdir(string name)
        {
            foreach (Folder a in CurrentFolder.Files)
            {
                if (a.Name == name)
                {
                    throw new FileSystemException("DUDE DEZE FILE BESTAAT AL");
                }
            }
            CurrentFolder.Files.Add(new Folder(name));
        }
    }
}
