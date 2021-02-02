using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.CLASSES
{
    class CLS_Client
    {
        private dbCommandeContext Db = new dbCommandeContext();
        private Client C; //table client

        //fonction pour ajouter client dans la bd
        public bool Ajouter_Client(string nom,string prenom, string adresse, string telephone, string email, string pays, string ville)
        {
            C = new Client(); //nouveau client 
            C.Nom_Client = nom;
            C.Prenom_Client = prenom;
            C.Adresse_Client = adresse;
            C.Telephone_Client = telephone;
            C.Pays_Client = pays;
            C.Ville_Client = ville;
            C.Email_Client = email;
            //verifier si le Nom et prenom existe deja dans la bd
            if(Db.Clients.SingleOrDefault(s=>s.Nom_Client==nom && C.Prenom_Client == prenom) == null)
            {
                Db.Clients.Add(C);
                Db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Modifier_Client(int id, string nom, string prenom, string adresse, string telephone, string email, string pays, string ville)
        {
            C = new Client();
            C = Db.Clients.SingleOrDefault(s => s.ID_Client == id); // verifier si id de client existe
            if(C!=null) //existe
            {
                C.Nom_Client = nom;
                C.Prenom_Client = prenom;
                C.Adresse_Client = adresse;
                C.Telephone_Client = telephone;
                C.Email_Client = email;
                C.Pays_Client = pays;
                C.Ville_Client = ville;
                Db.SaveChanges();
            }
        }
        //fonction supprimer client
        public void Supprimer_Client(int id)
        {
            C = new Client();
            C = Db.Clients.SingleOrDefault(s => s.ID_Client == id);
            if(C!=null) //existe
            {
                Db.Clients.Remove(C); //pour supprimer
                Db.SaveChanges();
            }
        }
    }
}
