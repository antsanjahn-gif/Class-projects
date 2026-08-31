namespace WindowsFormsApp2
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
            this.txtAgebox = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAgebox
            // 
            this.txtAgebox.Location = new System.Drawing.Point(320, 208);
            this.txtAgebox.Name = "txtAgebox";
            this.txtAgebox.Size = new System.Drawing.Size(100, 20);
            this.txtAgebox.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(320, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(139, 98);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(75, 20);
            this.username.TabIndex = 2;
            this.username.Text = "Enter name:";
            this.username.Click += new System.EventHandler(this.txtName_Click);
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(139, 215);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(56, 13);
            this.Age.TabIndex = 3;
            this.Age.Text = "Enter age:";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblmsg.Location = new System.Drawing.Point(139, 325);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 4;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(239, 270);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.Submit_load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.username);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAgebox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAgebox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button SubmitButton;
    }
}

