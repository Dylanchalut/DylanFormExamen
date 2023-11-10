namespace DylanFormExamen
{
    partial class FormElecteur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_courriel = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.label_gestion = new System.Windows.Forms.Label();
            this.comboBox_circonscription = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Le numéro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Circonscription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prénom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Courriel";
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(203, 101);
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(100, 20);
            this.textBox_numero.TabIndex = 5;
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(203, 198);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_nom.TabIndex = 6;
            this.textBox_nom.TextChanged += new System.EventHandler(this.textBox_nom_TextChanged);
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(203, 253);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(100, 20);
            this.textBox_prenom.TabIndex = 7;
            // 
            // textBox_courriel
            // 
            this.textBox_courriel.Location = new System.Drawing.Point(203, 312);
            this.textBox_courriel.Name = "textBox_courriel";
            this.textBox_courriel.Size = new System.Drawing.Size(100, 20);
            this.textBox_courriel.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(203, 362);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(462, 369);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 11;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // label_gestion
            // 
            this.label_gestion.AutoSize = true;
            this.label_gestion.Location = new System.Drawing.Point(359, 37);
            this.label_gestion.Name = "label_gestion";
            this.label_gestion.Size = new System.Drawing.Size(89, 13);
            this.label_gestion.TabIndex = 12;
            this.label_gestion.Text = "Gestion électeurs";
            // 
            // comboBox_circonscription
            // 
            this.comboBox_circonscription.FormattingEnabled = true;
            this.comboBox_circonscription.Items.AddRange(new object[] {
            "Gatineau",
            "Aylmer",
            "Hull"});
            this.comboBox_circonscription.Location = new System.Drawing.Point(197, 148);
            this.comboBox_circonscription.Name = "comboBox_circonscription";
            this.comboBox_circonscription.Size = new System.Drawing.Size(106, 21);
            this.comboBox_circonscription.TabIndex = 13;
            // 
            // FormElecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_circonscription);
            this.Controls.Add(this.label_gestion);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox_courriel);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.textBox_numero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormElecteur";
            this.Text = "FormElecteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_courriel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Label label_gestion;
        private System.Windows.Forms.ComboBox comboBox_circonscription;
    }
}