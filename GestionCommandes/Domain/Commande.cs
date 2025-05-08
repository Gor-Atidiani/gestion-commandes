namespace GestionCommandes.Domain
{
    public class Commande
    {
        public int Id { get; private set; }
        public DateTime DateCommande { get; private set; }
        public decimal Montant { get; private set; }
        public Client ClientAssocie { get; private set; }

        public Commande(int id, DateTime dateCommande, decimal montant, Client clientAssocie)
        {
            Id = id;
            DateCommande = dateCommande;
            Montant = montant;
            ClientAssocie = clientAssocie;
        }
    }
}
