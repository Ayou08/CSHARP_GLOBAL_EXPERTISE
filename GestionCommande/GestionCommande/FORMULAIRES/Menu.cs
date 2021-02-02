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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(227, 461);
            pnlPara.Visible = false;
        }
        //Desactiver le formulaire
        void desactiverForm()
        {
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncategorie.Enabled = false;
            btncommande.Enabled = false;
            btnuser.Enabled = false;
            btncopie.Enabled = false;
            btnrestaurer.Enabled = false;
            btndeconnecter.Enabled = false;
            pnlBut.Enabled = false;
            //connecter activer
            btnconnecter.Enabled = true;
        }
        //activer formulaire
        public void activeForm()
        {
            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncategorie.Enabled = true;
            btncommande.Enabled = true;
            btnuser.Enabled = true;
            btncopie.Enabled = true;
            btnrestaurer.Enabled = true;
            btndeconnecter.Enabled = true;
            pnlBut.Enabled = true;
            //connecter desactiver
            btnconnecter.Enabled = false;
            pnlPara.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(panel1.Width== 227)
            {
                panel1.Size=new Size(47, 461);
            }else
            {
                panel1.Size = new Size(227, 461);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnproduit.Top;
            if (!pnlafficher.Controls.Contains(USER_Liste_Produit.instance))
            {
                pnlafficher.Controls.Add(USER_Liste_Produit.instance);
                USER_Liste_Produit.instance.Dock = DockStyle.Fill;
                USER_Liste_Produit.instance.BringToFront();
            }
            else
            {
                USER_Liste_Produit.instance.BringToFront();
            }
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnclient.Top;
            if(!pnlafficher.Controls.Contains(USER_Liste_Client.instance))
            {
                pnlafficher.Controls.Add(USER_Liste_Client.instance);
                USER_Liste_Client.instance.Dock = DockStyle.Fill;
                USER_Liste_Client.instance.BringToFront();
            }else
            {
                USER_Liste_Client.instance.BringToFront();
            }
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncategorie.Top;
        }

        private void btncommande_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncommande.Top;
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnuser.Top;
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            pnlPara.Size = new Size(293, 159);
            pnlPara.Visible = !pnlPara.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //afficher le formulaire de connexion
            Connexion frmC = new Connexion(this); //this = Le formulaire du menu
            frmC.ShowDialog();
        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
