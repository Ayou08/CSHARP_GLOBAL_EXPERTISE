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
    public partial class Connexion : Form
    {
        private dbCommandeContext db;
        private Form frmMenu;
        // classe connecion
        CLASSES.Connexion C = new CLASSES.Connexion();
        public Connexion(Form Menu)
        {
            InitializeComponent();
            this.frmMenu = Menu;
            //initialise bas e donnee
            db = new dbCommandeContext();

        }
        //Pour verifier les champs obligatoires
        string testobligatoire()
        {
            if(txtNom.Text=="" || txtNom.Text== "Nom d'utilisateur") //si nom user est vide
            {
                return "Entrer votre Nom ";
            }
            if (txtMdp.Text == "" || txtMdp.Text == "Mot de passe") //si mdp user est vide
            {
                return "Entrer votre mot de passe ";
            }
            // si l'utilisateur a entre son nom et son mdp
            return null;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            //Quitter la fenetre
            this.Close();
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            //Pour Vider le textBox
            if(txtNom.Text=="Nom d'utilisateur")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.WhiteSmoke; //changer la couleur du texte
            }
        }

        private void txtMdp_Enter(object sender, EventArgs e)
        {
            //Pour Vider le textBox
            if (txtMdp.Text == "Mot de passe")
            {
                txtMdp.Text = "";
                txtMdp.UseSystemPasswordChar = false;
                txtMdp.PasswordChar = '*';
                txtMdp.ForeColor = Color.WhiteSmoke; //changer la couleur du texte
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if(txtNom.Text=="")
            {
                txtNom.Text = "Nom d'utilisateur";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtMdp_Leave(object sender, EventArgs e)
        {
            if (txtMdp.Text == "")
            {
                txtMdp.Text = "Mot de passe";
                txtMdp.UseSystemPasswordChar = true; //desactive passwordchar
                txtMdp.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(testobligatoire()==null)
            {
                if(C.ConnexionValide(db, txtNom.Text, txtMdp.Text)==true) //utilisateur existe
                {
                    MessageBox.Show("Connexion reussie", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmMenu as Menu).activeForm();
                    this.Close(); // quitter le formulaire de connexion
                }else //false n'existe pas
                {
                    MessageBox.Show("Connexion echouee", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show(testobligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
