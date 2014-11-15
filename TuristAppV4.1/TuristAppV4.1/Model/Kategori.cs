using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuristAppV4.Model
{
    class Katagori
    {
        private string _kategoriNavn;

        public string KategoriNavn
        {
            get { return _kategoriNavn; }
            set { _kategoriNavn = value; }
        }

        public Katagori(string kategoriNavn)
        {
            _kategoriNavn = kategoriNavn;
        }
    }
}
