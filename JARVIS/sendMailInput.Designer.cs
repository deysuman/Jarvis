namespace JARVIS
{
    partial class sendMailInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendMailInput));
            this.sendToInput = new System.Windows.Forms.ListBox();
            this.recipientInput = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.subjectInput = new System.Windows.Forms.TextBox();
            this.messageInput = new System.Windows.Forms.TextBox();
            this.addToList = new System.Windows.Forms.Button();
            this.addAttachments = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.attachmentsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sendToInput
            // 
            this.sendToInput.FormattingEnabled = true;
            this.sendToInput.Location = new System.Drawing.Point(12, 120);
            this.sendToInput.Name = "sendToInput";
            this.sendToInput.Size = new System.Drawing.Size(272, 82);
            this.sendToInput.TabIndex = 0;
            // 
            // recipientInput
            // 
            this.recipientInput.Location = new System.Drawing.Point(12, 60);
            this.recipientInput.Name = "recipientInput";
            this.recipientInput.Size = new System.Drawing.Size(181, 20);
            this.recipientInput.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Recipients";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(386, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Subject";
            // 
            // subjectInput
            // 
            this.subjectInput.Location = new System.Drawing.Point(386, 62);
            this.subjectInput.Name = "subjectInput";
            this.subjectInput.Size = new System.Drawing.Size(205, 20);
            this.subjectInput.TabIndex = 3;
            // 
            // messageInput
            // 
            this.messageInput.Location = new System.Drawing.Point(355, 120);
            this.messageInput.Multiline = true;
            this.messageInput.Name = "messageInput";
            this.messageInput.Size = new System.Drawing.Size(270, 250);
            this.messageInput.TabIndex = 5;
            this.messageInput.Text = "Message";
            // 
            // addToList
            // 
            this.addToList.Location = new System.Drawing.Point(209, 60);
            this.addToList.Name = "addToList";
            this.addToList.Size = new System.Drawing.Size(75, 23);
            this.addToList.TabIndex = 6;
            this.addToList.Text = "Add";
            this.addToList.UseVisualStyleBackColor = true;
            this.addToList.Click += new System.EventHandler(this.addToList_Click);
            // 
            // addAttachments
            // 
            this.addAttachments.Location = new System.Drawing.Point(209, 243);
            this.addAttachments.Name = "addAttachments";
            this.addAttachments.Size = new System.Drawing.Size(75, 23);
            this.addAttachments.TabIndex = 10;
            this.addAttachments.Text = "Add";
            this.addAttachments.UseVisualStyleBackColor = true;
            this.addAttachments.Click += new System.EventHandler(this.addAttachments_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 243);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Attachments";
            // 
            // attachmentsList
            // 
            this.attachmentsList.FormattingEnabled = true;
            this.attachmentsList.Location = new System.Drawing.Point(12, 288);
            this.attachmentsList.Name = "attachmentsList";
            this.attachmentsList.Size = new System.Drawing.Size(272, 82);
            this.attachmentsList.TabIndex = 7;
            // 
            // sendMailInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(637, 407);
            this.Controls.Add(this.addAttachments);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.attachmentsList);
            this.Controls.Add(this.addToList);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.subjectInput);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.recipientInput);
            this.Controls.Add(this.sendToInput);
            this.Name = "sendMailInput";
            this.Text = "sendMailInput";
            this.Load += new System.EventHandler(this.sendMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sendToInput;
        private System.Windows.Forms.TextBox recipientInput;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox subjectInput;
        private System.Windows.Forms.TextBox messageInput;
        private System.Windows.Forms.Button addToList;
        private System.Windows.Forms.Button addAttachments;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox attachmentsList;
    }
}