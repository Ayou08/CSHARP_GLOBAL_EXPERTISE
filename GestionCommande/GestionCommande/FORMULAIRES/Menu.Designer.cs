
namespace GestionCommande.FORMULAIRES
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBut = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.btncommande = new System.Windows.Forms.Button();
            this.btncategorie = new System.Windows.Forms.Button();
            this.btnproduit = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlPara = new System.Windows.Forms.Panel();
            this.btndeconnecter = new System.Windows.Forms.Button();
            this.btnrestaurer = new System.Windows.Forms.Button();
            this.btncopie = new System.Windows.Forms.Button();
            this.btnconnecter = new System.Windows.Forms.Button();
            this.pnlafficher = new System.Windows.Forms.Panel();
            this.btnpara = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlPara.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.pnlBut);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnuser);
            this.panel1.Controls.Add(this.btncommande);
            this.panel1.Controls.Add(this.btncategorie);
            this.panel1.Controls.Add(this.btnproduit);
            this.panel1.Controls.Add(this.btnclient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 461);
            this.panel1.TabIndex = 0;
            // 
            // pnlBut
            // 
            this.pnlBut.BackColor = System.Drawing.Color.Red;
            this.pnlBut.Location = new System.Drawing.Point(0, 89);
            this.pnlBut.Name = "pnlBut";
            this.pnlBut.Size = new System.Drawing.Size(13, 53);
            this.pnlBut.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::GestionCommande.Properties.Resources.Menu_32;
            this.button3.Location = new System.Drawing.Point(175, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 40);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnuser
            // 
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnuser.Image = global::GestionCommande.Properties.Resources.customer_service_icon;
            this.btnuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.Location = new System.Drawing.Point(0, 393);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(226, 53);
            this.btnuser.TabIndex = 8;
            this.btnuser.Text = "Utilisateur";
            this.btnuser.UseVisualStyleBackColor = true;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btncommande
            // 
            this.btncommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncommande.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncommande.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncommande.Image = global::GestionCommande.Properties.Resources.shopping_icon;
            this.btncommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncommande.Location = new System.Drawing.Point(0, 317);
            this.btncommande.Name = "btncommande";
            this.btncommande.Size = new System.Drawing.Size(226, 53);
            this.btncommande.TabIndex = 7;
            this.btncommande.Text = "Commande";
            this.btncommande.UseVisualStyleBackColor = true;
            this.btncommande.Click += new System.EventHandler(this.btncommande_Click);
            // 
            // btncategorie
            // 
            this.btncategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorie.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncategorie.Image = global::GestionCommande.Properties.Resources.Categorie;
            this.btncategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorie.Location = new System.Drawing.Point(0, 242);
            this.btncategorie.Name = "btncategorie";
            this.btncategorie.Size = new System.Drawing.Size(226, 53);
            this.btncategorie.TabIndex = 6;
            this.btncategorie.Text = "Categorie";
            this.btncategorie.UseVisualStyleBackColor = true;
            this.btncategorie.Click += new System.EventHandler(this.btncategorie_Click);
            // 
            // btnproduit
            // 
            this.btnproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnproduit.Image = global::GestionCommande.Properties.Resources.shop_cart_add_icon;
            this.btnproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduit.Location = new System.Drawing.Point(0, 168);
            this.btnproduit.Name = "btnproduit";
            this.btnproduit.Size = new System.Drawing.Size(226, 53);
            this.btnproduit.TabIndex = 5;
            this.btnproduit.Text = "Produit";
            this.btnproduit.UseVisualStyleBackColor = true;
            this.btnproduit.Click += new System.EventHandler(this.btnproduit_Click);
            // 
            // btnclient
            // 
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclient.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclient.Image = global::GestionCommande.Properties.Resources.Office_Client_Male_Light_icon;
            this.btnclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclient.Location = new System.Drawing.Point(0, 89);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(226, 53);
            this.btnclient.TabIndex = 4;
            this.btnclient.Text = "Client";
            this.btnclient.UseVisualStyleBackColor = true;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 15);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pnlPara);
            this.panel3.Controls.Add(this.pnlafficher);
            this.panel3.Controls.Add(this.btnpara);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(221, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 446);
            this.panel3.TabIndex = 2;
            // 
            // pnlPara
            // 
            this.pnlPara.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlPara.Controls.Add(this.btndeconnecter);
            this.pnlPara.Controls.Add(this.btnrestaurer);
            this.pnlPara.Controls.Add(this.btncopie);
            this.pnlPara.Controls.Add(this.btnconnecter);
            this.pnlPara.Location = new System.Drawing.Point(54, 4);
            this.pnlPara.Name = "pnlPara";
            this.pnlPara.Size = new System.Drawing.Size(293, 34);
            this.pnlPara.TabIndex = 9;
            // 
            // btndeconnecter
            // 
            this.btndeconnecter.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btndeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeconnecter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeconnecter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeconnecter.Image = global::GestionCommande.Properties.Resources.Deconnecte;
            this.btndeconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeconnecter.Location = new System.Drawing.Point(0, 115);
            this.btndeconnecter.Name = "btndeconnecter";
            this.btndeconnecter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndeconnecter.Size = new System.Drawing.Size(293, 30);
            this.btndeconnecter.TabIndex = 3;
            this.btndeconnecter.Text = "Deconnecter";
            this.btndeconnecter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btndeconnecter.UseVisualStyleBackColor = true;
            this.btndeconnecter.Click += new System.EventHandler(this.btndeconnecter_Click);
            // 
            // btnrestaurer
            // 
            this.btnrestaurer.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnrestaurer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestaurer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestaurer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrestaurer.Image = global::GestionCommande.Properties.Resources.Download;
            this.btnrestaurer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrestaurer.Location = new System.Drawing.Point(0, 79);
            this.btnrestaurer.Name = "btnrestaurer";
            this.btnrestaurer.Size = new System.Drawing.Size(293, 30);
            this.btnrestaurer.TabIndex = 2;
            this.btnrestaurer.Text = "Restaurer une copie enregistree";
            this.btnrestaurer.UseVisualStyleBackColor = true;
            // 
            // btncopie
            // 
            this.btncopie.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btncopie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncopie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncopie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncopie.Image = global::GestionCommande.Properties.Resources.Copier;
            this.btncopie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncopie.Location = new System.Drawing.Point(0, 36);
            this.btncopie.Name = "btncopie";
            this.btncopie.Size = new System.Drawing.Size(293, 30);
            this.btncopie.TabIndex = 1;
            this.btncopie.Text = "Creer une copie de l\'appli";
            this.btncopie.UseVisualStyleBackColor = true;
            // 
            // btnconnecter
            // 
            this.btnconnecter.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconnecter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnecter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnconnecter.Image = global::GestionCommande.Properties.Resources.Connected_16;
            this.btnconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconnecter.Location = new System.Drawing.Point(0, 0);
            this.btnconnecter.Name = "btnconnecter";
            this.btnconnecter.Size = new System.Drawing.Size(293, 30);
            this.btnconnecter.TabIndex = 0;
            this.btnconnecter.Text = "Connecter";
            this.btnconnecter.UseVisualStyleBackColor = true;
            this.btnconnecter.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlafficher
            // 
            this.pnlafficher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlafficher.BackColor = System.Drawing.SystemColors.Control;
            this.pnlafficher.Location = new System.Drawing.Point(0, 44);
            this.pnlafficher.Name = "pnlafficher";
            this.pnlafficher.Size = new System.Drawing.Size(820, 402);
            this.pnlafficher.TabIndex = 10;
            // 
            // btnpara
            // 
            this.btnpara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpara.Image = global::GestionCommande.Properties.Resources.Settings_32;
            this.btnpara.Location = new System.Drawing.Point(4, 4);
            this.btnpara.Name = "btnpara";
            this.btnpara.Size = new System.Drawing.Size(44, 32);
            this.btnpara.TabIndex = 8;
            this.btnpara.UseVisualStyleBackColor = true;
            this.btnpara.Click += new System.EventHandler(this.btnpara_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::GestionCommande.Properties.Resources.Subtract_32;
            this.button2.Location = new System.Drawing.Point(746, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 32);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::GestionCommande.Properties.Resources.Button_Delete_icon;
            this.button1.Location = new System.Drawing.Point(694, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 35);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlPara.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btncommande;
        private System.Windows.Forms.Button btncategorie;
        private System.Windows.Forms.Button btnproduit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlBut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlPara;
        private System.Windows.Forms.Button btndeconnecter;
        private System.Windows.Forms.Button btnrestaurer;
        private System.Windows.Forms.Button btncopie;
        private System.Windows.Forms.Button btnconnecter;
        private System.Windows.Forms.Button btnpara;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlafficher;
        private System.Windows.Forms.Button button1;
    }
}