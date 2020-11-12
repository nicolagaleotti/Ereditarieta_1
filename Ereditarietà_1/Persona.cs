using System;

namespace Ereditarietà_1
{
    public class Persona
    {
        private string nome, cognome;
        private DateTime dataDiNascita;
        private double altezza;

        public Persona(string nome, string cognome, DateTime dataDiNascita, double altezza)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataDiNascita = dataDiNascita;
            this.altezza = altezza;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetCognome()
        {
            return cognome;
        }

        public string GetNomeCompleto()
        {
            return (nome + " " + cognome);
        }

        public DateTime GetDataDiNascita()
        {
            return dataDiNascita;
        }

        public double GetAltezza()
        {
            return altezza;
        }
    }
}
