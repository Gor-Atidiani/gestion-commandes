using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionCommandes.Domain;

namespace GestionCommandes.Application
{
    public class CommandeService
    {

        public async Task PasserCommande(Commande commande)
        {
            Console.WriteLine("Preparation de l'envoi..");
            await Task.Delay(2000); // Simulate some delay  
            Console.WriteLine($"Commande envoye : {commande.Export()}");    
        }
       
    }
}
