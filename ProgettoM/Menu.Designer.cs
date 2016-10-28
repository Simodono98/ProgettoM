namespace ProgettoM
{
    partial class Menu
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(256, 61);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(98, 20);
            this.textBoxIP.TabIndex = 0;
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(256, 45);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(98, 13);
            this.labelIP.TabIndex = 1;
            this.labelIP.Text = "Inserisci indirizzo IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "AVVIA IL SERVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "CONNETTI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxDebug
            // 
            this.textBoxDebug.Location = new System.Drawing.Point(12, 153);
            this.textBoxDebug.Multiline = true;
            this.textBoxDebug.Name = "textBoxDebug";
            this.textBoxDebug.Size = new System.Drawing.Size(349, 104);
            this.textBoxDebug.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 269);
            this.Controls.Add(this.textBoxDebug);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textBoxIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menù";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDebug;
    }
}

