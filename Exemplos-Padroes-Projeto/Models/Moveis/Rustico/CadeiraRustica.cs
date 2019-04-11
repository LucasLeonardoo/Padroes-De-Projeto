using ExemplosPadrõesProjeto.Models.Moveis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPadroesProjeto.Models.Moveis.Rustico
{
    public class CadeiraRustica : Cadeira
    {
        public CadeiraRustica() : base("Cadeira Rustica")
        {
            this.URL = "http://staticmobly.akamaized.net/p/Barrocarte-Cadeira-RC3BAstica-Kononiale-em-Madeira-de-DemoliC3A7C3A3o---REF732-9725-456752-1-zoom.jpg";
        }
    }
}
