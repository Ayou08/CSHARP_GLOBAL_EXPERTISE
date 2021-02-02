using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.CLASSES
{
    class Connexion
    {
        //fonction pour verifier la connexion
        public bool ConnexionValide(dbCommandeContext db, string Nom, string Mot_de_passe)
        {
            Utilisateur U = new Utilisateur(); //table utilisateur
            U.NomUtilisateur = Nom;
            U.Mdp = Mot_de_passe;
            if (db.Utilisateurs.SingleOrDefault(s => s.NomUtilisateur == Nom && s.Mdp == Mot_de_passe)!=null)  //Si le nom d'utilisateur et le mdp existent
            {
                return true;
            }else // si n existe pas
            {
                return false;
            }
        }
    }
}
