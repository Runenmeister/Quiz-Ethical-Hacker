
namespace Quiz_Ethical_Hacker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnKontakt = new System.Windows.Forms.Button();
            this.Pb1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn4);
            this.panel1.Controls.Add(this.Btn3);
            this.panel1.Controls.Add(this.Btn2);
            this.panel1.Controls.Add(this.Btn1);
            this.panel1.Location = new System.Drawing.Point(12, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 210);
            this.panel1.TabIndex = 1;
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(330, 106);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(321, 97);
            this.Btn4.TabIndex = 3;
            this.Btn4.Tag = "4";
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(330, 3);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(321, 97);
            this.Btn3.TabIndex = 2;
            this.Btn3.Tag = "3";
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(3, 106);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(321, 97);
            this.Btn2.TabIndex = 1;
            this.Btn2.Tag = "2";
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(3, 3);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(321, 97);
            this.Btn1.TabIndex = 0;
            this.Btn1.Tag = "1";
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // LblQuestion
            // 
            this.LblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuestion.Location = new System.Drawing.Point(13, 265);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(775, 215);
            this.LblQuestion.TabIndex = 2;
            this.LblQuestion.Text = "Question";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(669, 663);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(119, 23);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnKontakt
            // 
            this.BtnKontakt.Location = new System.Drawing.Point(669, 634);
            this.BtnKontakt.Name = "BtnKontakt";
            this.BtnKontakt.Size = new System.Drawing.Size(119, 23);
            this.BtnKontakt.TabIndex = 4;
            this.BtnKontakt.Text = "Kontakt";
            this.BtnKontakt.UseVisualStyleBackColor = true;
            this.BtnKontakt.Click += new System.EventHandler(this.BtnKontakt_Click);
            // 
            // Pb1
            // 
            this.Pb1.InitialImage = null;
            this.Pb1.Location = new System.Drawing.Point(12, 12);
            this.Pb1.Name = "Pb1";
            this.Pb1.Size = new System.Drawing.Size(776, 246);
            this.Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb1.TabIndex = 0;
            this.Pb1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 705);
            this.Controls.Add(this.BtnKontakt);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz: Ethical Hacker | (c) 01/2024 by Runenmeister";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnKontakt;
    }
}

