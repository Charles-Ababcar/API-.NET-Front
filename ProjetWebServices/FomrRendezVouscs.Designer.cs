namespace ProjetWebServices
{
    partial class FomrRendezVouscs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FomrRendezVouscs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRv = new System.Windows.Forms.Button();
            this.comboBox_rv = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.libelle = new System.Windows.Forms.TextBox();
            this.hopitalCombox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Rendez Vous";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type de Rendez Vous";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(73, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Libelle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(92, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hopital";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(166, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 50);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(36, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(368, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Prise en Compte des Rendez  Vous";
            // 
            // btnRv
            // 
            this.btnRv.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRv.ForeColor = System.Drawing.Color.Black;
            this.btnRv.Location = new System.Drawing.Point(267, 397);
            this.btnRv.Name = "btnRv";
            this.btnRv.Size = new System.Drawing.Size(147, 37);
            this.btnRv.TabIndex = 3;
            this.btnRv.Text = "Soumettre";
            this.btnRv.UseVisualStyleBackColor = false;
            this.btnRv.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_rv
            // 
            this.comboBox_rv.FormattingEnabled = true;
            this.comboBox_rv.Location = new System.Drawing.Point(293, 236);
            this.comboBox_rv.Name = "comboBox_rv";
            this.comboBox_rv.Size = new System.Drawing.Size(121, 23);
            this.comboBox_rv.TabIndex = 4;
            this.comboBox_rv.SelectedIndexChanged += new System.EventHandler(this.comboBox_rv_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(251, 168);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // libelle
            // 
            this.libelle.Location = new System.Drawing.Point(326, 120);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(125, 23);
            this.libelle.TabIndex = 8;
            // 
            // hopitalCombox
            // 
            this.hopitalCombox.FormattingEnabled = true;
            this.hopitalCombox.Location = new System.Drawing.Point(293, 305);
            this.hopitalCombox.Name = "hopitalCombox";
            this.hopitalCombox.Size = new System.Drawing.Size(121, 23);
            this.hopitalCombox.TabIndex = 9;
           // this.hopitalCombox.SelectedIndexChanged += new System.EventHandler(this.hopitalCombox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(451, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FomrRendezVouscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1029, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hopitalCombox);
            this.Controls.Add(this.libelle);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBox_rv);
            this.Controls.Add(this.btnRv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FomrRendezVouscs";
            this.Text = "FomrRendezVouscs";
           //// this.Load += new System.EventHandler(this.FomrRendezVouscs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox_rv_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Button btnRv;
        private ComboBox comboBox_rv;
        private DateTimePicker dateTimePicker;
        private TextBox libelle;
        private ComboBox hopitalCombox;
        private Button button1;
    }
}