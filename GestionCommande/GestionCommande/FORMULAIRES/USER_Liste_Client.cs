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
    public partial class USER_Liste_Client : UserControl
    {
        private static USER_Liste_Client userClient;
        private dbCommandeContext Db;
        // creer une instance pour le usercontrolle
        public static USER_Liste_Client instance
        {
            get
            {
                if(userClient==null)
                {
                    userClient = new USER_Liste_Client();
                }
                return userClient;
            }
        }

        //Ajouter dans datagridview
        public void ActualiserDgv()
        {
            Db = new dbCommandeContext();
            dgvclient.Rows.Clear(); // VIder datagriid
            foreach(var S in Db.Clients)
            {
                //Ajouter les lignes dans datagrid
                dgvclient.Rows.Add(false, S.ID_Client, S.Nom_Client, S.Prenom_Client, S.Adresse_Client, S.Telephone_Client, S.Email_Client, S.Ville_Client, S.Pays_Client);
            }
        }
        //verifier combien de ligne est selectionner
        public string SelectVerif()
        {
            int Nbrligneselect = 0;
            for(int i=0; i < dgvclient.Rows.Count; i++)
            {
                if((bool)dgvclient.Rows[i].Cells[0].Value==true) //si ligne est selectionner
                {
                    Nbrligneselect++; //nombre ligne+1
                }
            }
            if(Nbrligneselect==0)
            {
                return "Selection le client a modifier";
            }
            if (Nbrligneselect > 1)
            {
                return "Selectionner seulement un seul client a modifier";
            }
            return null;
        }
        public USER_Liste_Client()
        {
            InitializeComponent();
            Db = new dbCommandeContext();
            // desactive textbox de recherche
            txtrechercher.Enabled = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtrechercher.Text=="Rechercher")
            {
                txtrechercher.Text = "";
                txtrechercher.ForeColor = Color.Black;
            }
        }

        private void USER_Liste_Client_Load(object sender, EventArgs e)
        {
            ActualiserDgv();
        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {
            //Afficher formulaire de saisie
            FORMULAIRES.ajouterModifierClient frmClient = new ajouterModifierClient(this);
            frmClient.ShowDialog();
        }
       

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            FORMULAIRES.ajouterModifierClient frmclient = new FORMULAIRES.ajouterModifierClient(this);
            if(SelectVerif()==null)
            {
                for(int i=0; i<dgvclient.Rows.Count;i++)
                {
                    if((bool)dgvclient.Rows[i].Cells[0].Value==true) // si le checkbox est vrai
                    {
                        frmclient.IDselect = (int)dgvclient.Rows[i].Cells[1].Value;
                        frmclient.nomClient.Text = dgvclient.Rows[i].Cells[2].Value.ToString();
                        frmclient.prenomClient.Text = dgvclient.Rows[i].Cells[3].Value.ToString();
                        frmclient.addClient.Text = dgvclient.Rows[i].Cells[4].Value.ToString();
                        frmclient.telClient.Text = dgvclient.Rows[i].Cells[5].Value.ToString();
                        frmclient.emailClient.Text = dgvclient.Rows[i].Cells[6].Value.ToString();
                        frmclient.villeClient.Text = dgvclient.Rows[i].Cells[7].Value.ToString();
                        frmclient.paysClient.Text = dgvclient.Rows[i].Cells[8].Value.ToString();
                    }
                }
                frmclient.lblTitre.Text = "Modifier client";
                frmclient.btnActualiser.Visible = false;
                frmclient.ShowDialog();
            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
   
        }

        private void btnsupprimerclient_Click(object sender, EventArgs e)
        {
            CLASSES.CLS_Client client = new CLASSES.CLS_Client();
            //pour supprimer touts les clients selectionner
            int select = 0;
            for(int i=0;i<dgvclient.Rows.Count;i++)
            {
                if((bool)dgvclient.Rows[i].Cells[0].Value==true)
                {
                    select++; //combien de ligne selectionner
                }
            }
            if(select==0)
            {
                MessageBox.Show("Aucun client selectionner", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }else
            {
                DialogResult R=
                    MessageBox.Show("Voulez-vous vraiment supprimer les clients", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R==DialogResult.Yes)
                {
                    //pour supprimer tout les clients selectionner
                    for (int i = 0; i < dgvclient.Rows.Count; i++)
                    {
                        if ((bool)dgvclient.Rows[i].Cells[0].Value == true)
                        {
                            client.Supprimer_Client(int.Parse(dgvclient.Rows[i].Cells[1].Value.ToString())); //id client
                        }
                    }
                    //actualiser datagrid
                    ActualiserDgv();
                    MessageBox.Show("Supprimer avec succes", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }else
                {
                    MessageBox.Show("Suppression annulee", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void comboRech_SelectedIndexChanged(object sender, EventArgs e)
        {
            //activer le textbox recherche si j'ai choisie un champ
            txtrechercher.Enabled = true;
            txtrechercher.Text = ""; //vider le textbox
        }

        private void txtrechercher_TextChanged(object sender, EventArgs e)
        {
            Db = new dbCommandeContext();
            var listerecherche = Db.Clients.ToList(); //listerecherche = liste des clients
            if(txtrechercher.Text!="")//pas vide
            {
                switch(comboRech.Text)
                {
                    case "Nom":
                        listerecherche = listerecherche.Where(s => s.Nom_Client.IndexOf(txtrechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        //stringComparaison.currentcultureignoreCase == sois j'ai ecrit la premiere lettre en majiscule ou en miniscule
                        //!=-1 existe dans la bd
                        break;
                    case "Prenom":
                        listerecherche = listerecherche.Where(s => s.Prenom_Client.IndexOf(txtrechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        
                        break;
                    case "Email":
                        listerecherche = listerecherche.Where(s => s.Email_Client.IndexOf(txtrechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

                        break;
                    case "Ville":
                        listerecherche = listerecherche.Where(s => s.Ville_Client.IndexOf(txtrechercher.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

                        break;
                }
            }
            //vider datagrid
            dgvclient.Rows.Clear();
            //ajouter listerecherche dans datagridview client
            foreach(var l in listerecherche)
            {
                dgvclient.Rows.Add(false, l.ID_Client, l.Nom_Client, l.Prenom_Client, l.Adresse_Client, l.Telephone_Client, l.Email_Client, l.Ville_Client, l.Pays_Client);
            }
        }

        private void txtrechercher_Leave(object sender, EventArgs e)
        {

        }
    }
}
