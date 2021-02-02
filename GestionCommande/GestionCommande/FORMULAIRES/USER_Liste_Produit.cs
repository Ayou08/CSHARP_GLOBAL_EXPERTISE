using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommande.FORMULAIRES
{
    public partial class USER_Liste_Produit : UserControl
    {
        private static USER_Liste_Produit userClient;
        private dbCommandeContext Db;
        // creer une instance pour le usercontrolle
        public static USER_Liste_Produit instance
        {
            get
            {
                if (userClient == null)
                {
                    userClient = new USER_Liste_Produit();
                }
                return userClient;
            }
        }
        public USER_Liste_Produit()
        {
            InitializeComponent();
            Db = new dbCommandeContext();
        }

        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {

        }

        private void txtrechercher_Enter(object sender, EventArgs e)
        {

            if (txtrechercher.Text == "Rechercher")
            {
                txtrechercher.Text = "";
                txtrechercher.ForeColor = Color.Black;
            }
        }
    }
}
