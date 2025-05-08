using System;

using GestionCommandes.Domain;

namespace GestionCommandes
{
    internal class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Example usage of the Commande and Client classes  
            var client = new Client(1, "Dupont", "jean.dupont@email.com");
            var commande = new Commande(1, DateTime.Now, 150.00m, client);

            Console.WriteLine(commande.Export());
        }
    }
}