namespace ContactFCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MemberGroupBox = new System.Windows.Forms.GroupBox();
            this.MemberCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.MemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemberGroupBox
            // 
            this.MemberGroupBox.Controls.Add(this.MemberCheckedListBox);
            this.MemberGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MemberGroupBox.Name = "MemberGroupBox";
            this.MemberGroupBox.Size = new System.Drawing.Size(200, 265);
            this.MemberGroupBox.TabIndex = 0;
            this.MemberGroupBox.TabStop = false;
            this.MemberGroupBox.Text = "Select FCC Members";
            // 
            // MemberCheckedListBox
            // 
            this.MemberCheckedListBox.FormattingEnabled = true;
            this.MemberCheckedListBox.Location = new System.Drawing.Point(7, 20);
            this.MemberCheckedListBox.Name = "MemberCheckedListBox";
            this.MemberCheckedListBox.Size = new System.Drawing.Size(177, 229);
            this.MemberCheckedListBox.TabIndex = 0;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(218, 32);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(294, 20);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(218, 74);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(294, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(218, 113);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(294, 148);
            this.messageTextBox.TabIndex = 3;
            this.messageTextBox.Text = resources.GetString("messageTextBox.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(519, 16);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(120, 245);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit To FCC Leaders";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 277);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.MemberGroupBox);
            this.Name = "Form1";
            this.Text = "Federal Communications Commission";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MemberGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MemberGroupBox;
        private System.Windows.Forms.CheckedListBox MemberCheckedListBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SubmitButton;
    }
}

