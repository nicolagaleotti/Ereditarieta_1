using System;
using Ereditarietà_1;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Docente d = new Docente("Arminio", "Aristogatti", DateTime.Now, 1.70, 7000, "Matematica");
            Console.WriteLine(d.GetNomeCompleto() + "\n" + d.GetDataDiNascita() + "\n" + d.GetAltezza() + "\n" + d.GetStipendio() + "\n" + d.GetMateria());
            Console.ReadLine();
        }
    }
}
