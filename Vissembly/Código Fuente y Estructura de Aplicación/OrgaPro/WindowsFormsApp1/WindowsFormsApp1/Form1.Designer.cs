namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BT_Princ = new System.Windows.Forms.Button();
            this.IRBox = new System.Windows.Forms.RichTextBox();
            this.PCBox = new System.Windows.Forms.RichTextBox();
            this.MDRBox = new System.Windows.Forms.RichTextBox();
            this.MARBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ACBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.InputMDR = new System.Windows.Forms.RichTextBox();
            this.InputMAR = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(306, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(338, 455);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // BT_Princ
            // 
            this.BT_Princ.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Princ.Location = new System.Drawing.Point(342, 548);
            this.BT_Princ.Name = "BT_Princ";
            this.BT_Princ.Size = new System.Drawing.Size(273, 40);
            this.BT_Princ.TabIndex = 4;
            this.BT_Princ.Text = "Enter";
            this.BT_Princ.UseVisualStyleBackColor = true;
            this.BT_Princ.Click += new System.EventHandler(this.button1_Click);
            // 
            // IRBox
            // 
            this.IRBox.Location = new System.Drawing.Point(686, 116);
            this.IRBox.Name = "IRBox";
            this.IRBox.Size = new System.Drawing.Size(65, 31);
            this.IRBox.TabIndex = 2;
            this.IRBox.Text = "";
            this.IRBox.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // PCBox
            // 
            this.PCBox.Location = new System.Drawing.Point(686, 185);
            this.PCBox.Name = "PCBox";
            this.PCBox.Size = new System.Drawing.Size(65, 31);
            this.PCBox.TabIndex = 2;
            this.PCBox.Text = "";
            this.PCBox.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // MDRBox
            // 
            this.MDRBox.Location = new System.Drawing.Point(686, 261);
            this.MDRBox.Name = "MDRBox";
            this.MDRBox.Size = new System.Drawing.Size(65, 31);
            this.MDRBox.TabIndex = 2;
            this.MDRBox.Text = "";
            this.MDRBox.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // MARBox
            // 
            this.MARBox.Location = new System.Drawing.Point(686, 340);
            this.MARBox.Name = "MARBox";
            this.MARBox.Size = new System.Drawing.Size(65, 31);
            this.MARBox.TabIndex = 2;
            this.MARBox.Text = "";
            this.MARBox.TextChanged += new System.EventHandler(this.richTextBox6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(706, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "IR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(706, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "PC";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "MDR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "MAR";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(699, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "AC";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ACBox
            // 
            this.ACBox.Location = new System.Drawing.Point(686, 411);
            this.ACBox.Name = "ACBox";
            this.ACBox.Size = new System.Drawing.Size(65, 31);
            this.ACBox.TabIndex = 16;
            this.ACBox.Text = "";
            this.ACBox.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged_1);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(667, 496);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(100, 96);
            this.richTextBox3.TabIndex = 18;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(650, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Step Process";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 70);
            this.button1.TabIndex = 20;
            this.button1.Text = "MM DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 39);
            this.label7.TabIndex = 21;
            this.label7.Text = "Instruction";
            this.label7.UseCompatibleTextRendering = true;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // InputMDR
            // 
            this.InputMDR.Location = new System.Drawing.Point(76, 400);
            this.InputMDR.Name = "InputMDR";
            this.InputMDR.Size = new System.Drawing.Size(93, 21);
            this.InputMDR.TabIndex = 23;
            this.InputMDR.Text = "";
            this.InputMDR.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged_1);
            // 
            // InputMAR
            // 
            this.InputMAR.Location = new System.Drawing.Point(76, 429);
            this.InputMAR.Name = "InputMAR";
            this.InputMAR.Size = new System.Drawing.Size(93, 21);
            this.InputMAR.TabIndex = 24;
            this.InputMAR.Text = "";
            this.InputMAR.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "MAR";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(191, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "MDR";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "ORG";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(87, 86);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(189, 31);
            this.richTextBox4.TabIndex = 29;
            this.richTextBox4.Text = "";
            this.richTextBox4.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(779, 600);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InputMAR);
            this.Controls.Add(this.InputMDR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ACBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MARBox);
            this.Controls.Add(this.MDRBox);
            this.Controls.Add(this.PCBox);
            this.Controls.Add(this.IRBox);
            this.Controls.Add(this.BT_Princ);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vissembly";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BT_Princ;
        private System.Windows.Forms.RichTextBox IRBox;
        private System.Windows.Forms.RichTextBox PCBox;
        private System.Windows.Forms.RichTextBox MDRBox;
        private System.Windows.Forms.RichTextBox MARBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ACBox;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox InputMDR;
        private System.Windows.Forms.RichTextBox InputMAR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Timer timer1;
    }
}

