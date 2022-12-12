using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Indirizzo
    {
        
            private string nome;
            private string cognome;
            private string via;
            private string città;
            private string provincia;
            private int zip;
        public Indirizzo(string nome, string cognome, string via, string città, string provincia, int zip)
        {
            this.nome = nome;
            this.cognome =cognome;
            this.via = via;
            this.città = città;
            this.provincia= provincia;
            this.zip = zip;

        }
        public string GetNome() {
            return nome;
        }
        public string GetCognome()
        {
            return cognome;
        }
        public string GetVia()
        {
            return via;
        }
        public string GetProvincia()
        {
            return provincia;
        }
        public string GetCittà()
        {
            return città;
        }
        public int GetZip()
        {
            return zip;
        }
        
    }
}
