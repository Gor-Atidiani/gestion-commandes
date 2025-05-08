namespace GestionCommandes.Domain
{
    public class Client
    {
        public int Id { get; private set; }
        public string Nom { get; private set; }
        public string Email { get; private set; }

        public Client(int id, string nom, string email)
        {
            Id = id;
            Nom = nom;
            Email = email;
        }
    }
}
