
namespace ConnectionSql
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
            this.BtnTeste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTeste
            // 
            this.BtnTeste.Location = new System.Drawing.Point(268, 191);
            this.BtnTeste.Name = "BtnTeste";
            this.BtnTeste.Size = new System.Drawing.Size(123, 74);
            this.BtnTeste.TabIndex = 0;
            this.BtnTeste.Text = "Testar";
            this.BtnTeste.UseVisualStyleBackColor = true;
            this.BtnTeste.Click += new System.EventHandler(this.BtnTeste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 501);
            this.Controls.Add(this.BtnTeste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTeste;
    }
}

