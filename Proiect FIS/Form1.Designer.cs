namespace Proiect_FIS
{
    partial class Form1
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
            this.COMPbut = new System.Windows.Forms.Button();
            this.CLIbut = new System.Windows.Forms.Button();
            this.ANGbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alegeți Utilizatorul";
            // 
            // COMPbut
            // 
            this.COMPbut.Location = new System.Drawing.Point(118, 370);
            this.COMPbut.Name = "COMPbut";
            this.COMPbut.Size = new System.Drawing.Size(138, 78);
            this.COMPbut.TabIndex = 1;
            this.COMPbut.Text = "Companie";
            this.COMPbut.UseVisualStyleBackColor = true;
            this.COMPbut.Click += new System.EventHandler(this.COMPbut_Click);
            // 
            // CLIbut
            // 
            this.CLIbut.Location = new System.Drawing.Point(403, 371);
            this.CLIbut.Name = "CLIbut";
            this.CLIbut.Size = new System.Drawing.Size(138, 79);
            this.CLIbut.TabIndex = 2;
            this.CLIbut.Text = "Client";
            this.CLIbut.UseVisualStyleBackColor = true;
            this.CLIbut.Click += new System.EventHandler(this.CLIbut_Click);
            // 
            // ANGbut
            // 
            this.ANGbut.Location = new System.Drawing.Point(686, 371);
            this.ANGbut.Name = "ANGbut";
            this.ANGbut.Size = new System.Drawing.Size(138, 78);
            this.ANGbut.TabIndex = 3;
            this.ANGbut.Text = "Angajat";
            this.ANGbut.UseVisualStyleBackColor = true;
            this.ANGbut.Click += new System.EventHandler(this.ANGbut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.ANGbut);
            this.Controls.Add(this.CLIbut);
            this.Controls.Add(this.COMPbut);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button COMPbut;
        private System.Windows.Forms.Button CLIbut;
        private System.Windows.Forms.Button ANGbut;
    }
}

