namespace MY_TIC_TAC_TOE_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tac1 = new System.Windows.Forms.Button();
            this.tac2 = new System.Windows.Forms.Button();
            this.tac3 = new System.Windows.Forms.Button();
            this.tac4 = new System.Windows.Forms.Button();
            this.tac5 = new System.Windows.Forms.Button();
            this.tac6 = new System.Windows.Forms.Button();
            this.tac7 = new System.Windows.Forms.Button();
            this.tac8 = new System.Windows.Forms.Button();
            this.tac9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tac1
            // 
            this.tac1.BackColor = System.Drawing.Color.Yellow;
            this.tac1.Location = new System.Drawing.Point(12, 44);
            this.tac1.Name = "tac1";
            this.tac1.Size = new System.Drawing.Size(107, 72);
            this.tac1.TabIndex = 0;
            this.tac1.UseVisualStyleBackColor = false;
            this.tac1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tac2
            // 
            this.tac2.BackColor = System.Drawing.Color.Yellow;
            this.tac2.Location = new System.Drawing.Point(125, 44);
            this.tac2.Name = "tac2";
            this.tac2.Size = new System.Drawing.Size(107, 72);
            this.tac2.TabIndex = 1;
            this.tac2.UseVisualStyleBackColor = false;
            this.tac2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tac3
            // 
            this.tac3.BackColor = System.Drawing.Color.Yellow;
            this.tac3.Location = new System.Drawing.Point(238, 44);
            this.tac3.Name = "tac3";
            this.tac3.Size = new System.Drawing.Size(107, 72);
            this.tac3.TabIndex = 2;
            this.tac3.UseVisualStyleBackColor = false;
            this.tac3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tac4
            // 
            this.tac4.BackColor = System.Drawing.Color.Yellow;
            this.tac4.Location = new System.Drawing.Point(14, 122);
            this.tac4.Name = "tac4";
            this.tac4.Size = new System.Drawing.Size(107, 72);
            this.tac4.TabIndex = 3;
            this.tac4.UseVisualStyleBackColor = false;
            // 
            // tac5
            // 
            this.tac5.BackColor = System.Drawing.Color.Yellow;
            this.tac5.Location = new System.Drawing.Point(125, 122);
            this.tac5.Name = "tac5";
            this.tac5.Size = new System.Drawing.Size(107, 72);
            this.tac5.TabIndex = 4;
            this.tac5.UseVisualStyleBackColor = false;
            // 
            // tac6
            // 
            this.tac6.BackColor = System.Drawing.Color.Yellow;
            this.tac6.Location = new System.Drawing.Point(238, 122);
            this.tac6.Name = "tac6";
            this.tac6.Size = new System.Drawing.Size(107, 72);
            this.tac6.TabIndex = 5;
            this.tac6.UseVisualStyleBackColor = false;
            this.tac6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tac7
            // 
            this.tac7.BackColor = System.Drawing.Color.Yellow;
            this.tac7.Location = new System.Drawing.Point(14, 200);
            this.tac7.Name = "tac7";
            this.tac7.Size = new System.Drawing.Size(107, 72);
            this.tac7.TabIndex = 6;
            this.tac7.UseVisualStyleBackColor = false;
            this.tac7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tac8
            // 
            this.tac8.BackColor = System.Drawing.Color.Yellow;
            this.tac8.Location = new System.Drawing.Point(125, 200);
            this.tac8.Name = "tac8";
            this.tac8.Size = new System.Drawing.Size(107, 72);
            this.tac8.TabIndex = 7;
            this.tac8.UseVisualStyleBackColor = false;
            // 
            // tac9
            // 
            this.tac9.BackColor = System.Drawing.Color.Yellow;
            this.tac9.Location = new System.Drawing.Point(238, 200);
            this.tac9.Name = "tac9";
            this.tac9.Size = new System.Drawing.Size(107, 72);
            this.tac9.TabIndex = 8;
            this.tac9.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(360, 315);
            this.Controls.Add(this.tac9);
            this.Controls.Add(this.tac8);
            this.Controls.Add(this.tac7);
            this.Controls.Add(this.tac6);
            this.Controls.Add(this.tac5);
            this.Controls.Add(this.tac4);
            this.Controls.Add(this.tac3);
            this.Controls.Add(this.tac2);
            this.Controls.Add(this.tac1);
            this.Name = "Form1";
            this.Text = "MY TIC-TAC-TOE GAME";
            this.ResumeLayout(false);

        }

        #endregion

        private Button tac1;
        private Button tac2;
        private Button tac3;
        private Button tac4;
        private Button tac5;
        private Button tac6;
        private Button tac7;
        private Button tac8;
        private Button tac9;
    }
}