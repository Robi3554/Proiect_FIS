namespace Proiect_FIS
{
    partial class AirlineWindow
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.adaugareBtn = new System.Windows.Forms.Button();
            this.codBox = new System.Windows.Forms.TextBox();
            this.tipBox = new System.Windows.Forms.TextBox();
            this.fcPret = new System.Windows.Forms.TextBox();
            this.leaveDate = new System.Windows.Forms.DateTimePicker();
            this.arriveDate = new System.Windows.Forms.DateTimePicker();
            this.leaveTime = new System.Windows.Forms.DateTimePicker();
            this.arriveTime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.fcNr = new System.Windows.Forms.TextBox();
            this.bcNr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.orasPle = new System.Windows.Forms.TextBox();
            this.orasSos = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bcPret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceți Datele Zborului";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codul Cursei :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipul Avionului :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Număr de Locuri :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prețuri :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ora de Plecare :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ora de Sosire :";
            // 
            // adaugareBtn
            // 
            this.adaugareBtn.Location = new System.Drawing.Point(286, 471);
            this.adaugareBtn.Name = "adaugareBtn";
            this.adaugareBtn.Size = new System.Drawing.Size(163, 81);
            this.adaugareBtn.TabIndex = 11;
            this.adaugareBtn.Text = "Adaugare Cursa";
            this.adaugareBtn.UseVisualStyleBackColor = true;
            this.adaugareBtn.Click += new System.EventHandler(this.adaugareBtn_Click);
            // 
            // codBox
            // 
            this.codBox.Location = new System.Drawing.Point(182, 123);
            this.codBox.Name = "codBox";
            this.codBox.Size = new System.Drawing.Size(100, 22);
            this.codBox.TabIndex = 12;
            // 
            // tipBox
            // 
            this.tipBox.Location = new System.Drawing.Point(182, 168);
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(100, 22);
            this.tipBox.TabIndex = 13;
            // 
            // fcPret
            // 
            this.fcPret.Location = new System.Drawing.Point(256, 264);
            this.fcPret.Name = "fcPret";
            this.fcPret.Size = new System.Drawing.Size(52, 22);
            this.fcPret.TabIndex = 15;
            // 
            // leaveDate
            // 
            this.leaveDate.CustomFormat = "";
            this.leaveDate.Location = new System.Drawing.Point(182, 350);
            this.leaveDate.Name = "leaveDate";
            this.leaveDate.Size = new System.Drawing.Size(267, 22);
            this.leaveDate.TabIndex = 17;
            this.leaveDate.ValueChanged += new System.EventHandler(this.leaveTime_ValueChanged);
            // 
            // arriveDate
            // 
            this.arriveDate.Location = new System.Drawing.Point(182, 395);
            this.arriveDate.Name = "arriveDate";
            this.arriveDate.Size = new System.Drawing.Size(267, 22);
            this.arriveDate.TabIndex = 18;
            // 
            // leaveTime
            // 
            this.leaveTime.Location = new System.Drawing.Point(473, 350);
            this.leaveTime.Name = "leaveTime";
            this.leaveTime.Size = new System.Drawing.Size(69, 22);
            this.leaveTime.TabIndex = 19;
            // 
            // arriveTime
            // 
            this.arriveTime.Location = new System.Drawing.Point(473, 395);
            this.arriveTime.Name = "arriveTime";
            this.arriveTime.Size = new System.Drawing.Size(69, 22);
            this.arriveTime.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "first calss :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "bussines class :";
            // 
            // fcNr
            // 
            this.fcNr.Location = new System.Drawing.Point(256, 210);
            this.fcNr.Name = "fcNr";
            this.fcNr.Size = new System.Drawing.Size(34, 22);
            this.fcNr.TabIndex = 23;
            // 
            // bcNr
            // 
            this.bcNr.Location = new System.Drawing.Point(455, 210);
            this.bcNr.Name = "bcNr";
            this.bcNr.Size = new System.Drawing.Size(31, 22);
            this.bcNr.TabIndex = 24;
            this.bcNr.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Oras Plecare :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(365, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Oras Sosire :";
            // 
            // orasPle
            // 
            this.orasPle.Location = new System.Drawing.Point(182, 305);
            this.orasPle.Name = "orasPle";
            this.orasPle.Size = new System.Drawing.Size(100, 22);
            this.orasPle.TabIndex = 27;
            // 
            // orasSos
            // 
            this.orasSos.Location = new System.Drawing.Point(473, 305);
            this.orasSos.Name = "orasSos";
            this.orasSos.Size = new System.Drawing.Size(100, 22);
            this.orasSos.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(545, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 29);
            this.label16.TabIndex = 34;
            this.label16.Text = "€";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "first calss :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(340, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "bussines class :";
            // 
            // bcPret
            // 
            this.bcPret.Location = new System.Drawing.Point(455, 264);
            this.bcPret.Name = "bcPret";
            this.bcPret.Size = new System.Drawing.Size(52, 22);
            this.bcPret.TabIndex = 37;
            // 
            // AirlineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 582);
            this.Controls.Add(this.bcPret);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.orasSos);
            this.Controls.Add(this.orasPle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bcNr);
            this.Controls.Add(this.fcNr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.arriveTime);
            this.Controls.Add(this.leaveTime);
            this.Controls.Add(this.arriveDate);
            this.Controls.Add(this.leaveDate);
            this.Controls.Add(this.fcPret);
            this.Controls.Add(this.tipBox);
            this.Controls.Add(this.codBox);
            this.Controls.Add(this.adaugareBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AirlineWindow";
            this.Text = "AirlineWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button adaugareBtn;
        private System.Windows.Forms.TextBox codBox;
        private System.Windows.Forms.TextBox tipBox;
        private System.Windows.Forms.TextBox fcPret;
        private System.Windows.Forms.DateTimePicker leaveDate;
        private System.Windows.Forms.DateTimePicker arriveDate;
        private System.Windows.Forms.DateTimePicker leaveTime;
        private System.Windows.Forms.DateTimePicker arriveTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fcNr;
        private System.Windows.Forms.TextBox bcNr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox orasPle;
        private System.Windows.Forms.TextBox orasSos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox bcPret;
    }
}