namespace ProjetWebServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.rendezVous = new System.Windows.Forms.Button();
            this.global_vue = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_maxed = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.contact = new System.Windows.Forms.Button();
            this.panelDesktop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rendezVous
            // 
            this.rendezVous.Location = new System.Drawing.Point(20, 303);
            this.rendezVous.Name = "rendezVous";
            this.rendezVous.Size = new System.Drawing.Size(131, 35);
            this.rendezVous.TabIndex = 3;
            this.rendezVous.Text = "Rendes Vous";
            this.rendezVous.UseVisualStyleBackColor = true;
            this.rendezVous.Click += new System.EventHandler(this.rendezVous_Click);
            // 
            // global_vue
            // 
            this.global_vue.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.global_vue.Location = new System.Drawing.Point(13, 358);
            this.global_vue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.global_vue.Name = "global_vue";
            this.global_vue.Size = new System.Drawing.Size(131, 36);
            this.global_vue.TabIndex = 2;
            this.global_vue.Text = "Carte Map";
            this.global_vue.UseVisualStyleBackColor = true;
            this.global_vue.Click += new System.EventHandler(this.global_vue_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(22, 188);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Ajout H";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(22, 248);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 37);
            this.button5.TabIndex = 0;
            this.button5.Text = "Structure Santées";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Ivory;
            this.panelDesktop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDesktop.BackgroundImage")));
            this.panelDesktop.Controls.Add(this.panelMenu);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1012, 496);
            this.panelDesktop.TabIndex = 4;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelMenu.Controls.Add(this.contact);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.global_vue);
            this.panelMenu.Controls.Add(this.rendezVous);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Location = new System.Drawing.Point(0, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(163, 490);
            this.panelMenu.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Accueil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_maxed);
            this.panel3.Controls.Add(this.btn_max);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Location = new System.Drawing.Point(190, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 54);
            this.panel3.TabIndex = 5;
            // 
            // btn_maxed
            // 
            this.btn_maxed.Location = new System.Drawing.Point(665, 3);
            this.btn_maxed.Name = "btn_maxed";
            this.btn_maxed.Size = new System.Drawing.Size(15, 23);
            this.btn_maxed.TabIndex = 2;
            this.btn_maxed.UseVisualStyleBackColor = true;
            this.btn_maxed.Click += new System.EventHandler(this.btn_maxed_Click);
            // 
            // btn_max
            // 
            this.btn_max.Location = new System.Drawing.Point(766, 10);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(37, 23);
            this.btn_max.TabIndex = 1;
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(249, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 25);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Covid19";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(13, 413);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(131, 28);
            this.contact.TabIndex = 5;
            this.contact.Text = "Contact";
            this.contact.UseVisualStyleBackColor = true;
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 496);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelDesktop);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button4;
        private Button button5;
        private Button button3;
        private Button global_vue;
        private Button rendezVous;
        private Panel panelDesktop;
        private Panel panel3;
        private Button button1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Button btn_max;
        private Button btn_maxed;
        private Panel panelMenu;
        private Button contact;
    }
}