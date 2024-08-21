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
            // aplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_welcome);
            this.Name = "aplication";
            this.Text = "aplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_welcome;
    }
}