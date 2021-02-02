using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GestionCommande.FORMULAIRES
{
    public partial class ajouterModifierClient : Form
    {
        private UserControl usclient;
        public ajouterModifierClient(UserControl userC)
        {
            InitializeComponent();
            this.usclient = userC;
        }

        //Les champs obligatoires
        string testobligatoire()
        {
            if(nomClient.Text=="" || nomClient.Text == "")
            {
                return "Entrer le nom du client";
            }
       

            if (prenomClient.Text == "" || prenomClient.Text == "")
            {
                return "Entrer le prenom du client";
            }
            

            if (telClient.Text == "" || telClient.Text == "")
            {
                return "Entrer le telephone du client";
            }
            

            if (addClient.Text == "" || addClient.Text == "")
            {
                return "Entrer l'adresse du client";
            }
            

            if (villeClient.Text == "" || villeClient.Text == "")
            {
                return "Entrer la ville du client";
            }
            

            if (paysClient.Text == "" || paysClient.Text == "")
            {
                return "Entrer le peys du client";
            }
            //Verifie email valide ou non
            if(emailClient.Text!="" || emailClient.Text!="")
            {
                try
                {
                    new MailAddress(emailClient.Text); //Pour verifier email si valide ou non
                }catch(Exception e)
                {
                    return "Email invalide";
                }
            }
            return null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nomClient_Enter(object sender, EventArgs e)
        {
            if(nomClient.Text == "")
            {
                nomClient.Text = "";
                nomClient.ForeColor = Color.White;
            }
        }

        private void nomClient_Leave(object sender, EventArgs e)
        {
            if (nomClient.Text == "")
            {
                nomClient.Text = "";
                nomClient.ForeColor = Color.Silver;
            }
        }

        private void prenomClient_Enter(object sender, EventArgs e)
        {
            if (prenomClient.Text == "")
            {
                prenomClient.Text = "";
                prenomClient.ForeColor = Color.White;
            }
        }

        private void prenomClient_Leave(object sender, EventArgs e)
        {
            if (prenomClient.Text == "")
            {
                prenomClient.Text = "";
                prenomClient.ForeColor = Color.Silver;
            }
        }
        private void addClient_Enter(object sender, EventArgs e)
        {
            if (addClient.Text == "")
            {
                addClient.Text = "";
                addClient.ForeColor = Color.White;
            }
        }

        private void addClient_Leave(object sender, EventArgs e)
        {
            if (addClient.Text == "")
            {
                addClient.Text = "";
                addClient.ForeColor = Color.Silver;
            }
        }
        private void paysClient_Enter(object sender, EventArgs e)
        {
            if (paysClient.Text == "")
            {
                paysClient.Text = "";
                paysClient.ForeColor = Color.White;
            }
        }

        private void paysClient_Leave(object sender, EventArgs e)
        {
            if (paysClient.Text == "")
            {
                paysClient.Text = "";
                paysClient.ForeColor = Color.Silver;
            }
        }
        private void telClient_Enter(object sender, EventArgs e)
        {
            if (telClient.Text == "")
            {
                telClient.Text = "";
                telClient.ForeColor = Color.White;
            }
        }

        private void telClient_Leave(object sender, EventArgs e)
        {
            if (telClient.Text == "")
            {
                telClient.Text = "";
                telClient.ForeColor = Color.Silver;
            }
        }
        private void emailClient_Enter(object sender, EventArgs e)
        {
            if (emailClient.Text == "")
            {
                emailClient.Text = "";
                emailClient.ForeColor = Color.White;
            }
        }

        private void emailClient_Leave(object sender, EventArgs e)
        {
            if (emailClient.Text == "")
            {
                emailClient.Text = "";
                emailClient.ForeColor = Color.Silver;
            }
        }

        
        private void villeClient_Enter(object sender, EventArgs e)
        {
            if (villeClient.Text == "")
            {
                villeClient.Text = "";
                villeClient.ForeColor = Color.White;
            }
        }

        private void villeClient_Leave(object sender, EventArgs e)
        {
            if (villeClient.Text == "")
            {
                villeClient.Text = "";
                villeClient.ForeColor = Color.Silver;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void telClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox numeric
            if(e.KeyChar<48 || e.KeyChar > 57)//code asci des numeros
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        public int IDselect;
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if(testobligatoire()!=null)
            {
                MessageBox.Show(testobligatoire(),"Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else
            if(lblTitre.Text=="Ajouter Client")
            {
                CLASSES.CLS_Client client = new CLASSES.CLS_Client();
                if(client.Ajouter_Client(nomClient.Text, prenomClient.Text, addClient.Text, telClient.Text, emailClient.Text, paysClient.Text, villeClient.Text) == true)
                {
                    MessageBox.Show("Client ajoute avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usclient as USER_Liste_Client).ActualiserDgv();
                }
                else
                {
                    MessageBox.Show("Nom et Prenom existent deja dans la bd", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // si lbltitre=Modifier client
            {
                CLASSES.CLS_Client client = new CLASSES.CLS_Client();
                DialogResult R = MessageBox.Show("Voulez-vous vraiment modifier ce client ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    client.Modifier_Client(IDselect,nomClient.Text, prenomClient.Text, addClient.Text, telClient.Text, emailClient.Text, paysClient.Text, villeClient.Text);
                    //Pour actualiser datagridview
                    (usclient as USER_Liste_Client).ActualiserDgv();
                    MessageBox.Show("Client Modife avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Modification est annulee", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            //vider les text box
            nomClient.Text = ""; nomClient.ForeColor = Color.Silver;
            prenomClient.Text = ""; prenomClient.ForeColor = Color.Silver;
            telClient.Text = ""; telClient.ForeColor = Color.Silver;
            addClient.Text = ""; addClient.ForeColor = Color.Silver;
            paysClient.Text = ""; paysClient.ForeColor = Color.Silver;
            villeClient.Text = ""; villeClient.ForeColor = Color.Silver;
            emailClient.Text = ""; emailClient.ForeColor = Color.Silver;
        }

        private void ajouterModifierClient_Load(object sender, EventArgs e)
        {

        }
    }
}
