namespace ProjetWebServices
{
    partial class AjoutStructure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutStructure));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nom_structure = new System.Windows.Forms.TextBox();
            this.capacite = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.nbrdoseVaccin = new System.Windows.Forms.TextBox();
            this.nbre_places = new System.Windows.Forms.TextBox();
            this.btn_structure = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Modifier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(187, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(85, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prise en Compte des structures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Structure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(39, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(40, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contact";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(39, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Capacite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(299, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de Vaccins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(299, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombres Places";
            // 
            // nom_structure
            // 
            this.nom_structure.Location = new System.Drawing.Point(169, 136);
            this.nom_structure.Name = "nom_structure";
            this.nom_structure.Size = new System.Drawing.Size(100, 23);
            this.nom_structure.TabIndex = 4;
            this.nom_structure.TextChanged += new System.EventHandler(this.nom_structure_TextChanged);
            // 
            // capacite
            // 
            this.capacite.Location = new System.Drawing.Point(169, 273);
            this.capacite.Name = "capacite";
            this.capacite.Size = new System.Drawing.Size(100, 23);
            this.capacite.TabIndex = 5;
            this.capacite.TextChanged += new System.EventHandler(this.capacite_TextChanged);
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(169, 207);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(100, 23);
            this.adresse.TabIndex = 6;
            this.adresse.TextChanged += new System.EventHandler(this.adresse_TextChanged);
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(169, 332);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(100, 23);
            this.contact.TabIndex = 7;
            this.contact.TextChanged += new System.EventHandler(this.contact_TextChanged);
            // 
            // nbrdoseVaccin
            // 
            this.nbrdoseVaccin.Location = new System.Drawing.Point(331, 184);
            this.nbrdoseVaccin.Name = "nbrdoseVaccin";
            this.nbrdoseVaccin.Size = new System.Drawing.Size(100, 23);
            this.nbrdoseVaccin.TabIndex = 8;
            this.nbrdoseVaccin.TextChanged += new System.EventHandler(this.nbrdoseVaccin_TextChanged);
            // 
            // nbre_places
            // 
            this.nbre_places.Location = new System.Drawing.Point(321, 311);
            this.nbre_places.Name = "nbre_places";
            this.nbre_places.Size = new System.Drawing.Size(100, 23);
            this.nbre_places.TabIndex = 9;
            this.nbre_places.TextChanged += new System.EventHandler(this.nbre_places_TextChanged);
            // 
            // btn_structure
            // 
            this.btn_structure.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_structure.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_structure.ForeColor = System.Drawing.Color.Black;
            this.btn_structure.Location = new System.Drawing.Point(110, 401);
            this.btn_structure.Name = "btn_structure";
            this.btn_structure.Size = new System.Drawing.Size(122, 43);
            this.btn_structure.TabIndex = 10;
            this.btn_structure.Text = "Enregistre";
            this.btn_structure.UseVisualStyleBackColor = false;
            this.btn_structure.Click += new System.EventHandler(this.btn_structure_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(489, 285);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(251, 407);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(99, 36);
            this.Modifier.TabIndex = 12;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(417, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AjoutStructure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_structure);
            this.Controls.Add(this.nbre_places);
            this.Controls.Add(this.nbrdoseVaccin);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.capacite);
            this.Controls.Add(this.nom_structure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AjoutStructure";
            this.Text = "AjoutStructure";
            this.Load += new System.EventHandler(this.AjoutStructure_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label4;
        private TextBox nom_structure;
        private TextBox capacite;
        private TextBox adresse;
        private TextBox contact;
        private TextBox nbrdoseVaccin;
        private TextBox nbre_places;
        private Button btn_structure;
        private DataGridView dataGridView1;
        private Button Modifier;
        private Button button1;
    }
}