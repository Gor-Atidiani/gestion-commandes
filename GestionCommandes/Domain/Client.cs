using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommandes.Domain
{
    public class Client
    {
        private int _id;    
        private string _nom;
        private string _email;


        public Client(int id, string nom, string email)
        {
            _id = id;
            _nom = nom;
            _email = email;
        }   

    }
}
