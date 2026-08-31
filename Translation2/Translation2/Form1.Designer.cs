namespace Translation2
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
            this.Autembtn = new System.Windows.Forms.Button();
            this.descenditbtn = new System.Windows.Forms.Button();
            this.mediumbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTranslator = new System.Windows.Forms.GroupBox();
            this.lblTranslator.SuspendLayout();
            this.SuspendLayout();
            // 
            // Autembtn
            // 
            this.Autembtn.Location = new System.Drawing.Point(284, 62);
            this.Autembtn.Name = "Autembtn";
            this.Autembtn.Size = new System.Drawing.Size(75, 23);
            this.Autembtn.TabIndex = 0;
            this.Autembtn.Text = "Autem";
            this.Autembtn.UseVisualStyleBackColor = true;
            this.Autembtn.Click += new System.EventHandler(this.Autembtn_Click);
            // 
            // descenditbtn
            // 
            this.descenditbtn.Location = new System.Drawing.Point(284, 138);
            this.descenditbtn.Name = "descenditbtn";
            this.descenditbtn.Size = new System.Drawing.Size(75, 23);
            this.descenditbtn.TabIndex = 1;
            this.descenditbtn.Text = "Descendit";
            this.descenditbtn.UseVisualStyleBackColor = true;
            this.descenditbtn.Click += new System.EventHandler(this.descenditbtn_Click);
            // 
            // mediumbtn
            // 
            this.mediumbtn.Location = new System.Drawing.Point(284, 225);
            this.mediumbtn.Name = "mediumbtn";
            this.mediumbtn.Size = new System.Drawing.Size(75, 23);
            this.mediumbtn.TabIndex = 2;
            this.mediumbtn.Text = "Medium";
            this.mediumbtn.UseVisualStyleBackColor = true;
            this.mediumbtn.Click += new System.EventHandler(this.mediumbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // lblTranslator
            // 
            this.lblTranslator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTranslator.Controls.Add(this.mediumbtn);
            this.lblTranslator.Controls.Add(this.descenditbtn);
            this.lblTranslator.Controls.Add(this.Autembtn);
            this.lblTranslator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTranslator.Location = new System.Drawing.Point(49, 29);
            this.lblTranslator.Name = "lblTranslator";
            this.lblTranslator.Size = new System.Drawing.Size(653, 369);
            this.lblTranslator.TabIndex = 4;
            this.lblTranslator.TabStop = false;
            this.lblTranslator.Text = "Latin to English Translator:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTranslator);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.lblTranslator.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Autembtn;
        private System.Windows.Forms.Button descenditbtn;
        private System.Windows.Forms.Button mediumbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox lblTranslator;
    }
}

