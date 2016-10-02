using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef4FileSystem.Model
{
    public class TextFile : File
    {
        private string _BestandsNaam;
        private string _Tekst;
        private string _ListName;

        public string ListName
        {
            get { return _ListName; }
            set { _ListName = value; }
        }


        private string BestandsNaam
        {
            get { return _BestandsNaam; }
            set { _BestandsNaam = value; }
        }
        private string tekstinhoud { get; set; }



        public string Tekst
        {
            get { return _Tekst; }
            set { _Tekst = value; }
        }

        public TextFile(string naam) : base(naam)
        {
            ListName = naam;
        }

    }
}
