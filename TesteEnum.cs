using System;

namespace csharp_learning;

class Program
{    
    public static void Main(string[] args)
    {
        DiaSemana dia1 = DiaSemana.SEXTA;
        DiaSemana dia2 = (DiaSemana) 2;
        DiaSemana dia3 = new DiaSemana();
        
        Console.WriteLine(dia1); // SEXTA

        Console.WriteLine(dia2); // QUARTA

        Console.WriteLine(dia3); // SEGUNDA
    }
}