using DesignPatterns.ChainOfResponsibility.Conceptual.Entitites;
using System;

namespace DesignPatterns.ChainOfResponsibility.Conceptual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A outra parte do código do cliente constrói a corrente real.
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            monkey.SetNext(squirrel).SetNext(dog);

            // O cliente deve ser capaz de enviar uma requisição para qualquer manipulador, não
            // apenas o primeiro da cadeia.
            Console.WriteLine("Chain: Monkey > Squirrel > dog\n");
            Client.ClientCode(monkey);
            Console.ReadLine();

            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);
        }
    }
}
