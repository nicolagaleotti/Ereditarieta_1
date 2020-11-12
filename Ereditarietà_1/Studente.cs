using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà_1
{
    public class Studente : Persona
    {
        private string nome, cognome, classe;
        private DateTime dataDiNascita;
        private double altezza;

        public Studente(string nome, string cognome, DateTime dataDiNascita, double altezza, string classe):base(nome, cognome, dataDiNascita, altezza)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataDiNascita = dataDiNascita;
            this.altezza = altezza;
            this.classe = classe;
        }

        public string GetClasse()
        {
            return classe;
        }
    }
}
