using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazioneBiblioteca
{
    internal class Biblioteca
    {
        public string titolo;
        public string autore;
        public int pagine;
        public int tempo;
        public Biblioteca(string Titolo, string Autore,int Pagine)
        {
            this.titolo = Titolo;
            this.autore = Autore;
            this.pagine = Pagine;
        }
        
        public string getTitolo() { return titolo; }
        public string getAutore() { return autore; }
        public void setTitolo(string Titolo) { this.titolo = Titolo; }
        public void setAutore(string Autore) { this.autore = Autore; }
        public string toString() { return ("Il libro è " + this.titolo + "il suo autotre è " + this.autore); }
        public int readingTime() {
            if (pagine < 100)
            {
                int tempo = 1;
            }
            if(pagine > 100 && pagine < 200)
            {
                int tempo = 2;
            }
            else
            {
                int tempo = 3;
            }
            return (tempo);
        }
    }

    internal class Biblioteca
    {
        public string titolo;
        public string autore;
        public int pagine;
        public int tempo;
        public Biblioteca(string Titolo, string Autore, int Pagine)
        {
            this.titolo = Titolo;
            this.autore = Autore;
            this.pagine = Pagine;
        }

        public string getTitolo() { return titolo; }
        public string getAutore() { return autore; }
        public void setTitolo(string Titolo) { this.titolo = Titolo; }
        public void setAutore(string Autore) { this.autore = Autore; }
        public string toString() { return ("Il libro è " + this.titolo + "il suo autotre è " + this.autore); }
        public int readingTime()
        {
            if (pagine < 100)
            {
                int tempo = 1;
            }
            if (pagine > 100 && pagine < 200)
            {
                int tempo = 2;
            }
            else
            {
                int tempo = 3;
            }
            return (tempo);
        }
    }



}
