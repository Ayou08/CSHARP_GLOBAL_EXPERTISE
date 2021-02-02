
namespace GestionCommande.FORMULAIRES
{
    partial class USER_Liste_Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtrechercher = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboRech = new System.Windows.Forms.ComboBox();
            this.dgvclient = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsupprimerclient = new System.Windows.Forms.Button();
            this.btnmodifierclient = new System.Windows.Forms.Button();
            this.btnajouterclient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(13, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 3);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(13, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 3);
            this.panel2.TabIndex = 4;
            // 
            // txtrechercher
            // 
            this.txtrechercher.BackColor = System.Drawing.SystemColors.Control;
            this.txtrechercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrechercher.ForeColor = System.Drawing.Color.DimGray;
            this.txtrechercher.Location = new System.Drawing.Point(536, 107);
            this.txtrechercher.Multiline = true;
            this.txtrechercher.Name = "txtrechercher";
            this.txtrechercher.Size = new System.Drawing.Size(303, 33);
            this.txtrechercher.TabIndex = 5;
            this.txtrechercher.Text = "Rechercher";
            this.txtrechercher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrechercher.TextChanged += new System.EventHandler(this.txtrechercher_TextChanged);
            this.txtrechercher.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtrechercher.Leave += new System.EventHandler(this.txtrechercher_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(536, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 3);
            this.panel3.TabIndex = 5;
            // 
            // comboRech
            // 
            this.comboRech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRech.FormattingEnabled = true;
            this.comboRech.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Telephone",
            "Email",
            "Ville",
            "Pays"});
            this.comboRech.Location = new System.Drawing.Point(164, 112);
            this.comboRech.Name = "comboRech";
            this.comboRech.Size = new System.Drawing.Size(338, 33);
            this.comboRech.TabIndex = 6;
            this.comboRech.SelectedIndexChanged += new System.EventHandler(this.comboRech_SelectedIndexChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvclient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column6,
            this.Column7});
            this.dgvclient.EnableHeadersVisualStyles = false;
            this.dgvclient.Location = new System.Drawing.Point(3, 185);
            this.dgvclient.Name = "dgvclient";
            this.dgvclient.RowHeadersVisible = false;
            this.dgvclient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvclient.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvclient.Size = new System.Drawing.Size(1134, 532);
            this.dgvclient.TabIndex = 7;
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
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adresse";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telephone";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ville";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Pays";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // btnsupprimerclient
            // 
            this.btnsupprimerclient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsupprimerclient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsupprimerclient.FlatAppearance.BorderSize = 0;
            this.btnsupprimerclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimerclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimerclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsupprimerclient.Image = global::GestionCommande.Properties.Resources.Close_2_icon;
            this.btnsupprimerclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimerclient.Location = new System.Drawing.Point(712, 20);
            this.btnsupprimerclient.Name = "btnsupprimerclient";
            this.btnsupprimerclient.Size = new System.Drawing.Size(308, 46);
            this.btnsupprimerclient.TabIndex = 2;
            this.btnsupprimerclient.Text = "Supprimer";
            this.btnsupprimerclient.UseVisualStyleBackColor = false;
            this.btnsupprimerclient.Click += new System.EventHandler(this.btnsupprimerclient_Click);
            // 
            // btnmodifierclient
            // 
            this.btnmodifierclient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmodifierclient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmodifierclient.FlatAppearance.BorderSize = 0;
            this.btnmodifierclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifierclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifierclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodifierclient.Image = global::GestionCommande.Properties.Resources.Recycle_iconaaa;
            this.btnmodifierclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifierclient.Location = new System.Drawing.Point(365, 20);
            this.btnmodifierclient.Name = "btnmodifierclient";
            this.btnmodifierclient.Size = new System.Drawing.Size(308, 46);
            this.btnmodifierclient.TabIndex = 1;
            this.btnmodifierclient.Text = "Modifier";
            this.btnmodifierclient.UseVisualStyleBackColor = false;
            this.btnmodifierclient.Click += new System.EventHandler(this.btnmodifierclient_Click);
            // 
            // btnajouterclient
            // 
            this.btnajouterclient.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnajouterclient.FlatAppearance.BorderSize = 0;
            this.btnajouterclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouterclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnajouterclient.Image = global::GestionCommande.Properties.Resources.Actions_list_add_icon;
            this.btnajouterclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouterclient.Location = new System.Drawing.Point(13, 20);
            this.btnajouterclient.Name = "btnajouterclient";
            this.btnajouterclient.Size = new System.Drawing.Size(308, 46);
            this.btnajouterclient.TabIndex = 0;
            this.btnajouterclient.Text = "Ajouter";
            this.btnajouterclient.UseVisualStyleBackColor = false;
            this.btnajouterclient.Click += new System.EventHandler(this.btnajouterclient_Click);
            // 
            // USER_Liste_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvclient);
            this.Controls.Add(this.comboRech);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtrechercher);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsupprimerclient);
            this.Controls.Add(this.btnmodifierclient);
            this.Controls.Add(this.btnajouterclient);
            this.Name = "USER_Liste_Client";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.USER_Liste_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnajouterclient;
        private System.Windows.Forms.Button btnmodifierclient;
        private System.Windows.Forms.Button btnsupprimerclient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtrechercher;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboRech;
        private System.Windows.Forms.DataGridView dgvclient;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
