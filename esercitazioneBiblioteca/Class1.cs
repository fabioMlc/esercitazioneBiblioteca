using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazioneBiblioteca
{
    internal class Libro
    {
        public string titolo;
        public string autore;
        public int pagine;
        public int tempo;
        public Libro(string Titolo, string Autore,int Pagine)
        {
            this.titolo = Titolo;
            this.autore = Autore;
            this.pagine = Pagine;
        }
        
        public string getTitolo() { return titolo; }
        public string getAutore() { return autore; }
        public int getPagine() { return pagine; }
        public void setTitolo(string Titolo) { this.titolo = Titolo; }
        public void setAutore(string Autore) { this.autore = Autore; }
        public void setPagine(int Pagine) { this.pagine = Pagine; }

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

    internal class Biblioteca1
    {
        public string titolo;
        public string autore;
        public string nomeBiblioteca;
        public string orariApertura;
        public string orariChiusura;
        public Biblioteca1(string Titolo, string Autore, string nomeBiblioteca,string orariApertura, string orariChiusura)
        {
            this.titolo = Titolo;
            this.autore = Autore;
            this.nomeBiblioteca = nomeBiblioteca;
            this.orariApertura = orariApertura;
            this.orariChiusura = orariChiusura;
        }

        public string getTitolo() { return titolo; }
        public string getAutore() { return autore; }
        public string getNomeBiblioteca() {return nomeBiblioteca;}
        public string getOrariApertura() {return orariApertura;}    
        public string getOrariChiusura() {return orariChiusura;}

        public void setTitolo(string Titolo) { this.titolo = Titolo; }
        public void setAutore(string Autore) { this.autore = Autore; }
        public void setNomeBiblioteca(string nomeBilioteca) { this.nomeBiblioteca = nomeBilioteca; }
        public void setOrariApertura(string orariApertura) { this.nomeBiblioteca = orariApertura; }
        public void setOrariChiusura(string orariChiusura) { this.orariChiusura = orariChiusura; }
        public string toString() { return ("Il libro è " + this.titolo + "il suo autotre è " + this.autore); }
        
    }



}
