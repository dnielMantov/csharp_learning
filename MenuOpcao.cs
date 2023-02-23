using System;

namespace csharp_learning;

class Menu
{
    enum Opcao { CRIAR = 1, DELETAR, ATUALIZAR, SAIR }

    static void MenuOpcao(Opcao opcao)
    {
        switch(opcao)
        {
            case Opcao.CRIAR:
                Console.WriteLine("Criar algo");
                break;
            case Opcao.DELETAR:
                Console.WriteLine("Deletar algo");
                break;
            case Opcao.ATUALIZAR:
                Console.WriteLine("Atualizando...");
                break;
            case Opcao.SAIR:
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.WriteLine("Opção Inválida");
                break;
        }
    }

    static void MenuExibir()
    {
        Console.WriteLine("""
        1. Criar
        2. Deletar
        3. Atualizar
        4. Sair
        """);
    }

    static void Main(string[] args)
    {
        MenuExibir();
        int escolha = int.Parse(Console.ReadLine());
        MenuOpcao((Opcao) escolha);
    }
}