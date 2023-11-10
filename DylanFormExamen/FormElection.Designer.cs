namespace DylanFormExamen
{
    partial class FormElection
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
            this.label_nom = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.dateTimePicker_Election = new System.Windows.Forms.DateTimePicker();
            this.comboBox_nom = new System.Windows.Forms.ComboBox();
            this.button_créer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(130, 82);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(29, 13);
            this.label_nom.TabIndex = 0;
            this.label_nom.Text = "Nom";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(130, 159);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(78, 13);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "Date d\'élection";
            // 
            // dateTimePicker_Election
            // 
            this.dateTimePicker_Election.Location = new System.Drawing.Point(297, 151);
            this.dateTimePicker_Election.Name = "dateTimePicker_Election";
            this.dateTimePicker_Election.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Election.TabIndex = 2;
            // 
            // comboBox_nom
            // 
            this.comboBox_nom.FormattingEnabled = true;
            this.comboBox_nom.Items.AddRange(new object[] {
            "Municipal",
            "Provincial",
            "Federal"});
            this.comboBox_nom.Location = new System.Drawing.Point(314, 82);
            this.comboBox_nom.Name = "comboBox_nom";
            this.comboBox_nom.Size = new System.Drawing.Size(121, 21);
            this.comboBox_nom.TabIndex = 3;
            // 
            // button_créer
            // 
            this.button_créer.Location = new System.Drawing.Point(314, 245);
            this.button_créer.Name = "button_créer";
            this.button_créer.Size = new System.Drawing.Size(75, 23);
            this.button_créer.TabIndex = 4;
            this.button_créer.Text = "Créer";
            this.button_créer.UseVisualStyleBackColor = true;
            this.button_créer.Click += new System.EventHandler(this.button_créer_Click);
            // 
            // FormElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_créer);
            this.Controls.Add(this.comboBox_nom);
            this.Controls.Add(this.dateTimePicker_Election);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_nom);
            this.Name = "FormElection";
            this.Text = "FormElection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Election;
        private System.Windows.Forms.ComboBox comboBox_nom;
        private System.Windows.Forms.Button button_créer;
    }
}