using System;
using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsibility.Conceptual.Entitites
{
    public class Client : AbstractHandler
    {
        // O código do cliente geralmente é adequado para trabalhar com um único manipulador.
        // Dentro na maioria dos casos, nem sabe que o manipulador faz parte de uma cadeia.
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var food in new List<string> {"Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                var result = handler.Handle(food);

                if (result != null)
                {
                    Console.WriteLine($"     {result}");
                }
                else
                {
                    Console.WriteLine($"   {food} was left untouched.");
                }
            }
        }
    }
}
