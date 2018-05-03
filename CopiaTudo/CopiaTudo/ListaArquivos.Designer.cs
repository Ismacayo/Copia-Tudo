namespace CopiaTudo
{
    partial class ListaArquivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaArquivos));
            this.ListaArquivosText = new System.Windows.Forms.RichTextBox();
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaArquivosText
            // 
            this.ListaArquivosText.Location = new System.Drawing.Point(-1, 0);
            this.ListaArquivosText.Name = "ListaArquivosText";
            this.ListaArquivosText.Size = new System.Drawing.Size(246, 267);
            this.ListaArquivosText.TabIndex = 0;
            this.ListaArquivosText.Text = "";
            this.ListaArquivosText.TextChanged += new System.EventHandler(this.ListaArquivosText_TextChanged);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(101, 273);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(42, 23);
            this.Sair.TabIndex = 1;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // ListaArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 304);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.ListaArquivosText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaArquivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListaArquivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaArquivos_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ListaArquivosText;
        private System.Windows.Forms.Button Sair;
    }
}