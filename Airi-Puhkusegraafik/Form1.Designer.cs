namespace Airi_Puhkusegraafik
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
            this.VacationWrite = new System.Windows.Forms.GroupBox();
            this.refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.AddVacation = new System.Windows.Forms.Button();
            this.Person_Enter = new System.Windows.Forms.ComboBox();
            this.VacationRead = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Puhkused = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Person_Exit = new System.Windows.Forms.ListBox();
            this.VacationWrite.SuspendLayout();
            this.VacationRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // VacationWrite
            // 
            this.VacationWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.VacationWrite.Controls.Add(this.refresh);
            this.VacationWrite.Controls.Add(this.label5);
            this.VacationWrite.Controls.Add(this.label4);
            this.VacationWrite.Controls.Add(this.label3);
            this.VacationWrite.Controls.Add(this.label1);
            this.VacationWrite.Controls.Add(this.dateEnd);
            this.VacationWrite.Controls.Add(this.dateStart);
            this.VacationWrite.Controls.Add(this.AddVacation);
            this.VacationWrite.Controls.Add(this.Person_Enter);
            this.VacationWrite.Location = new System.Drawing.Point(22, 45);
            this.VacationWrite.Name = "VacationWrite";
            this.VacationWrite.Size = new System.Drawing.Size(516, 303);
            this.VacationWrite.TabIndex = 0;
            this.VacationWrite.TabStop = false;
            this.VacationWrite.Text = "Puhkuse Sisestus";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(48, 265);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(182, 27);
            this.refresh.TabIndex = 10;
            this.refresh.Text = "Uuenda";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tõõtaja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Puhkuse Lõpp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Puhkuse Algus";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(285, 122);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(217, 20);
            this.dateEnd.TabIndex = 5;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(44, 122);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 4;
            // 
            // AddVacation
            // 
            this.AddVacation.Location = new System.Drawing.Point(289, 265);
            this.AddVacation.Name = "AddVacation";
            this.AddVacation.Size = new System.Drawing.Size(214, 28);
            this.AddVacation.TabIndex = 3;
            this.AddVacation.Text = "Lisa Puhkus";
            this.AddVacation.UseVisualStyleBackColor = true;
            this.AddVacation.Click += new System.EventHandler(this.AddVacation_Click);
            // 
            // Person_Enter
            // 
            this.Person_Enter.FormattingEnabled = true;
            this.Person_Enter.Location = new System.Drawing.Point(44, 52);
            this.Person_Enter.Name = "Person_Enter";
            this.Person_Enter.Size = new System.Drawing.Size(227, 21);
            this.Person_Enter.TabIndex = 2;
            // 
            // VacationRead
            // 
            this.VacationRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.VacationRead.Controls.Add(this.label6);
            this.VacationRead.Controls.Add(this.Puhkused);
            this.VacationRead.Controls.Add(this.label2);
            this.VacationRead.Controls.Add(this.Person_Exit);
            this.VacationRead.Location = new System.Drawing.Point(596, 45);
            this.VacationRead.Name = "VacationRead";
            this.VacationRead.Size = new System.Drawing.Size(490, 303);
            this.VacationRead.TabIndex = 1;
            this.VacationRead.TabStop = false;
            this.VacationRead.Text = "Puhkuse Tulemus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tõõtaja";
            // 
            // Puhkused
            // 
            this.Puhkused.FormattingEnabled = true;
            this.Puhkused.Location = new System.Drawing.Point(263, 64);
            this.Puhkused.Name = "Puhkused";
            this.Puhkused.Size = new System.Drawing.Size(213, 225);
            this.Puhkused.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Puhkused";
            // 
            // Person_Exit
            // 
            this.Person_Exit.FormattingEnabled = true;
            this.Person_Exit.Location = new System.Drawing.Point(33, 66);
            this.Person_Exit.Name = "Person_Exit";
            this.Person_Exit.Size = new System.Drawing.Size(160, 225);
            this.Person_Exit.TabIndex = 0;
            this.Person_Exit.SelectedIndexChanged += new System.EventHandler(this.Puhkused_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 375);
            this.Controls.Add(this.VacationRead);
            this.Controls.Add(this.VacationWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.VacationWrite.ResumeLayout(false);
            this.VacationWrite.PerformLayout();
            this.VacationRead.ResumeLayout(false);
            this.VacationRead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox VacationWrite;
        private System.Windows.Forms.ComboBox Person_Enter;
        private System.Windows.Forms.GroupBox VacationRead;
        private System.Windows.Forms.Button AddVacation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Person_Exit;
        private System.Windows.Forms.ListBox Puhkused;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button refresh;
    }
}

