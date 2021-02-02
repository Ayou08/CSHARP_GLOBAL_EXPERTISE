
namespace GestionCommande.FORMULAIRES
{
    partial class USER_Liste_Produit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvclient = new System.Windows.Forms.DataGridView();
            this.comboRech = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtrechercher = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsupprimerprod = new System.Windows.Forms.Button();
            this.btnmodifierprod = new System.Windows.Forms.Button();
            this.btnajouterprod = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.btnimprimertout = new System.Windows.Forms.Button();
            this.btnimprimerSelect = new System.Windows.Forms.Button();
            this.column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvclient
            // 
            this.dgvclient.AllowUserToAddRows = false;
            this.dgvclient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvclient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvclient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvclient.EnableHeadersVisualStyles = false;
            this.dgvclient.Location = new System.Drawing.Point(1, 177);
            this.dgvclient.Name = "dgvclient";
            this.dgvclient.RowHeadersVisible = false;
            this.dgvclient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvclient.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvclient.Size = new System.Drawing.Size(1134, 446);
            this.dgvclient.TabIndex = 16;
            // 
            // comboRech
            // 
            this.comboRech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRech.FormattingEnabled = true;
            this.comboRech.Items.AddRange(new object[] {
            "Nom",
            "Categorie"});
            this.comboRech.Location = new System.Drawing.Point(162, 104);
            this.comboRech.Name = "comboRech";
            this.comboRech.Size = new System.Drawing.Size(338, 33);
            this.comboRech.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(534, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 3);
            this.panel3.TabIndex = 13;
            // 
            // txtrechercher
            // 
            this.txtrechercher.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrechercher.ForeColor = System.Drawing.Color.DimGray;
            this.txtrechercher.Location = new System.Drawing.Point(534, 99);
            this.txtrechercher.Multiline = true;
            this.txtrechercher.Name = "txtrechercher";
            this.txtrechercher.Size = new System.Drawing.Size(303, 33);
            this.txtrechercher.TabIndex = 14;
            this.txtrechercher.Text = "Rechercher";
            this.txtrechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercher.Enter += new System.EventHandler(this.txtrechercher_Enter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(11, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 3);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(11, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 3);
            this.panel1.TabIndex = 11;
            // 
            // btnsupprimerprod
            // 
            this.btnsupprimerprod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsupprimerprod.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsupprimerprod.FlatAppearance.BorderSize = 0;
            this.btnsupprimerprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimerprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimerprod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsupprimerprod.Image = global::GestionCommande.Properties.Resources.Close_2_icon;
            this.btnsupprimerprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimerprod.Location = new System.Drawing.Point(481, 12);
            this.btnsupprimerprod.Name = "btnsupprimerprod";
            this.btnsupprimerprod.Size = new System.Drawing.Size(211, 46);
            this.btnsupprimerprod.TabIndex = 10;
            this.btnsupprimerprod.Text = "Supprimer";
            this.btnsupprimerprod.UseVisualStyleBackColor = false;
            // 
            // btnmodifierprod
            // 
            this.btnmodifierprod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmodifierprod.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmodifierprod.FlatAppearance.BorderSize = 0;
            this.btnmodifierprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifierprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifierprod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodifierprod.Image = global::GestionCommande.Properties.Resources.Recycle_iconaaa;
            this.btnmodifierprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifierprod.Location = new System.Drawing.Point(239, 12);
            this.btnmodifierprod.Name = "btnmodifierprod";
            this.btnmodifierprod.Size = new System.Drawing.Size(221, 46);
            this.btnmodifierprod.TabIndex = 9;
            this.btnmodifierprod.Text = "Modifier";
            this.btnmodifierprod.UseVisualStyleBackColor = false;
            // 
            // btnajouterprod
            // 
            this.btnajouterprod.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnajouterprod.FlatAppearance.BorderSize = 0;
            this.btnajouterprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouterprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterprod.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnajouterprod.Image = global::GestionCommande.Properties.Resources.Actions_list_add_icon;
            this.btnajouterprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouterprod.Location = new System.Drawing.Point(11, 12);
            this.btnajouterprod.Name = "btnajouterprod";
            this.btnajouterprod.Size = new System.Drawing.Size(202, 46);
            this.btnajouterprod.TabIndex = 8;
            this.btnajouterprod.Text = "Ajouter";
            this.btnajouterprod.UseVisualStyleBackColor = false;
            // 
            // btnPhoto
            // 
            this.btnPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhoto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPhoto.FlatAppearance.BorderSize = 0;
            this.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPhoto.Image = global::GestionCommande.Properties.Resources.Pictures_icon;
            this.btnPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhoto.Location = new System.Drawing.Point(718, 12);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(272, 46);
            this.btnPhoto.TabIndex = 17;
            this.btnPhoto.Text = "Afficher Photo";
            this.btnPhoto.UseVisualStyleBackColor = false;
            // 
            // btnimprimertout
            // 
            this.btnimprimertout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnimprimertout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnimprimertout.FlatAppearance.BorderSize = 0;
            this.btnimprimertout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimertout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimertout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimprimertout.Image = global::GestionCommande.Properties.Resources.Imprimer;
            this.btnimprimertout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimertout.Location = new System.Drawing.Point(466, 644);
            this.btnimprimertout.Name = "btnimprimertout";
            this.btnimprimertout.Size = new System.Drawing.Size(308, 46);
            this.btnimprimertout.TabIndex = 19;
            this.btnimprimertout.Text = "Imprimer tout";
            this.btnimprimertout.UseVisualStyleBackColor = false;
            // 
            // btnimprimerSelect
            // 
            this.btnimprimerSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnimprimerSelect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnimprimerSelect.FlatAppearance.BorderSize = 0;
            this.btnimprimerSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimerSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimprimerSelect.Image = global::GestionCommande.Properties.Resources.Imprimer;
            this.btnimprimerSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimerSelect.Location = new System.Drawing.Point(114, 644);
            this.btnimprimerSelect.Name = "btnimprimerSelect";
            this.btnimprimerSelect.Size = new System.Drawing.Size(308, 46);
            this.btnimprimerSelect.TabIndex = 18;
            this.btnimprimerSelect.Text = "Imprimer produit";
            this.btnimprimerSelect.UseVisualStyleBackColor = false;
            // 
            // column1
            // 
            this.column1.HeaderText = "Select";
            this.column1.Name = "column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantite";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Categorie";
            this.Column5.Name = "Column5";
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnimprimertout);
            this.Controls.Add(this.btnimprimerSelect);
            this.Controls.Add(this.btnPhoto);
            this.Controls.Add(this.dgvclient);
            this.Controls.Add(this.comboRech);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtrechercher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsupprimerprod);
            this.Controls.Add(this.btnmodifierprod);
            this.Controls.Add(this.btnajouterprod);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.USER_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvclient;
        private System.Windows.Forms.ComboBox comboRech;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtrechercher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsupprimerprod;
        private System.Windows.Forms.Button btnmodifierprod;
        private System.Windows.Forms.Button btnajouterprod;
        private System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnimprimertout;
        private System.Windows.Forms.Button btnimprimerSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
