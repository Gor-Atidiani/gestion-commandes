using System;
using System.Globalization;

using GestionCommandes.Application;
using GestionCommandes.Domain;

namespace GestionCommandes
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fr-FR");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("fr-FR");

            // Example usage of the Commande and Client classes
            // 
            var service = new CommandeService();
          
            var client = new Client(1, "Dupont", "jean.dupont@email.com");
            var commande = new Commande(1, DateTime.Now, 150.00m, client);
            await service.PasserCommande(commande);
            Console.WriteLine(commande.Export());
        }
    }
}