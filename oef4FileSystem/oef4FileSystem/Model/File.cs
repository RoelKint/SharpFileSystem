using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef4FileSystem.Model
{
    public abstract class File
    {
        private String _Name;
        private Folder _Parent;
        private bool _IsRoot;
        private string _PathName; //Dit nog te implementeren schat! voorlaatste puntje
        #region setters
        public string PathName
        {
            get { return _PathName; }
            set { _PathName = value; }
        }


        private bool IsRoot
        {
            get
            {
                return _IsRoot;
            }
            set
            {
                if (Parent == null)
                { _IsRoot = true; }
                else
                { _IsRoot = false; }
            }
        }

        public Folder Parent
        {
            get { return _Parent; }
            set { _Parent = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        #endregion iets
        public File(string naam)
        {
            bool a = true;
            int jo = 1234;
            string streep = ".";
            naam.Contains(streep);
            if (   naam == null)
            {
                throw new FileSystemException("alstublieft geef een waarde in zonder /");
            } else
            {
                Name = naam;
            }
            
        }

        
    }
}
