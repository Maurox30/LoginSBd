namespace login2
{
    partial class aplication
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
            this.l_welcome = new System.Windows.Forms.Label();
            this.l_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_welcome
            // 
            this.l_welcome.AutoSize = true;
            this.l_welcome.Location = new System.Drawing.Point(83, 58);
            this.l_welcome.Name = "l_welcome";
            this.l_welcome.Size = new System.Drawing.Size(60, 13);
            this.l_welcome.TabIndex = 0;
            this.l_welcome.Text = "Bienvenido";
            // 
            // l_user
            // 
            this.l_user.AutoSize = true;
            this.l_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_user.Location = new System.Drawing.Point(121, 99);
            this.l_user.Name = "l_user";
            this.l_user.Size = new System.Drawing.Size(104, 24);
            this.l_user.TabIndex = 1;
            this.l_user.Text = "cartel_wel";
            // 
            // aplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_user);
            this.Controls.Add(this.l_welcome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "aplication";
            this.Text = "aplication";
            this.Load += new System.EventHandler(this.aplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_welcome;
        private System.Windows.Forms.Label l_user;
    }
}