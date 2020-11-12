using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà_1
{
    public class Lavoratore : Persona
    {
        private string nome, cognome;
        private DateTime dataDiNascita;
        private double altezza;
        private int stipendio;

        public Lavoratore(string nome, string cognome, DateTime dataDiNascita, double altezza, int stipendio) :base(nome, cognome, dataDiNascita, altezza)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataDiNascita = dataDiNascita;
            this.altezza = altezza;
            this.stipendio = stipendio;
        }

        public int GetStipendio()
        {
            return stipendio;
        }
    }
}
