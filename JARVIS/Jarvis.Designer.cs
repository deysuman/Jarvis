namespace JARVIS
{
    partial class Jarvis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jarvis));
            this.JarvisApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // JarvisApp
            // 
            this.JarvisApp.Icon = ((System.Drawing.Icon)(resources.GetObject("JarvisApp.Icon")));
            this.JarvisApp.Text = "Jarvis App";
            this.JarvisApp.Visible = true;
            this.JarvisApp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.JarvisApp_MouseDoubleClick);
            // 
            // Jarvis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 355);
            this.Name = "Jarvis";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Jarvis_FormClosing);
            this.Click += new System.EventHandler(this.Jarvis_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Jarvis_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon JarvisApp;
    }
}

