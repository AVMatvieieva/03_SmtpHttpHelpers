namespace _03_SmtpHttpHelpers
{
    partial class Form2
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
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TopicBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Send_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Main_textBox = new System.Windows.Forms.TextBox();
            this.Attache_textBox = new System.Windows.Forms.TextBox();
            this.attached_label = new System.Windows.Forms.Label();
            this.Check_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your messege";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(38, 108);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(100, 20);
            this.EmailBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Topic";
            // 
            // TopicBox
            // 
            this.TopicBox.Location = new System.Drawing.Point(38, 69);
            this.TopicBox.Name = "TopicBox";
            this.TopicBox.Size = new System.Drawing.Size(100, 20);
            this.TopicBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(38, 30);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 6;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(424, 147);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 8;
            this.Add_Button.Text = "Attache file";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(424, 234);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(75, 23);
            this.Send_Button.TabIndex = 9;
            this.Send_Button.Text = "Send Email";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(424, 274);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 10;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Main_textBox
            // 
            this.Main_textBox.Location = new System.Drawing.Point(40, 150);
            this.Main_textBox.Multiline = true;
            this.Main_textBox.Name = "Main_textBox";
            this.Main_textBox.Size = new System.Drawing.Size(272, 147);
            this.Main_textBox.TabIndex = 12;
            // 
            // Attache_textBox
            // 
            this.Attache_textBox.Location = new System.Drawing.Point(505, 150);
            this.Attache_textBox.Name = "Attache_textBox";
            this.Attache_textBox.Size = new System.Drawing.Size(245, 20);
            this.Attache_textBox.TabIndex = 11;
            // 
            // attached_label
            // 
            this.attached_label.AutoSize = true;
            this.attached_label.Location = new System.Drawing.Point(40, 300);
            this.attached_label.Name = "attached_label";
            this.attached_label.Size = new System.Drawing.Size(0, 13);
            this.attached_label.TabIndex = 13;
            // 
            // Check_button
            // 
            this.Check_button.Location = new System.Drawing.Point(424, 191);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(75, 23);
            this.Check_button.TabIndex = 14;
            this.Check_button.Text = "Check Email";
            this.Check_button.UseVisualStyleBackColor = true;
            this.Check_button.Click += new System.EventHandler(this.Check_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Check_button);
            this.Controls.Add(this.attached_label);
            this.Controls.Add(this.Main_textBox);
            this.Controls.Add(this.Attache_textBox);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TopicBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TopicBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.TextBox Main_textBox;
        private System.Windows.Forms.TextBox Attache_textBox;
        private System.Windows.Forms.Label attached_label;
        private System.Windows.Forms.Button Check_button;
    }
}