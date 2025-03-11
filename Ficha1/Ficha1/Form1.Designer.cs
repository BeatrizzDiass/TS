namespace Ficha1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.LabelCopyMessage = new System.Windows.Forms.Label();
            this.progressBarCopyFile = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelCopyMessage
            // 
            this.LabelCopyMessage.AutoSize = true;
            this.LabelCopyMessage.Location = new System.Drawing.Point(351, 246);
            this.LabelCopyMessage.Name = "LabelCopyMessage";
            this.LabelCopyMessage.Size = new System.Drawing.Size(136, 16);
            this.LabelCopyMessage.TabIndex = 1;
            this.LabelCopyMessage.Text = "Copy Message Label";
            this.LabelCopyMessage.Visible = false;
            // 
            // progressBarCopyFile
            // 
            this.progressBarCopyFile.Location = new System.Drawing.Point(315, 195);
            this.progressBarCopyFile.Name = "progressBarCopyFile";
            this.progressBarCopyFile.Size = new System.Drawing.Size(200, 23);
            this.progressBarCopyFile.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBarCopyFile);
            this.Controls.Add(this.LabelCopyMessage);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelCopyMessage;
        private System.Windows.Forms.ProgressBar progressBarCopyFile;
    }
}

