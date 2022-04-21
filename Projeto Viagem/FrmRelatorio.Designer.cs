namespace Projeto_Viagem
{
    partial class FrmRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
            this.rtRelatorio = new System.Windows.Forms.RichTextBox();
            this.btFechar = new System.Windows.Forms.Button();
            this.btExportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtRelatorio
            // 
            this.rtRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtRelatorio.Location = new System.Drawing.Point(1, 295);
            this.rtRelatorio.Name = "rtRelatorio";
            this.rtRelatorio.Size = new System.Drawing.Size(476, 267);
            this.rtRelatorio.TabIndex = 0;
            this.rtRelatorio.Text = "";
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.Red;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(385, 565);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(85, 28);
            this.btFechar.TabIndex = 1;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btExportar
            // 
            this.btExportar.BackColor = System.Drawing.Color.Lime;
            this.btExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportar.Location = new System.Drawing.Point(10, 566);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(369, 26);
            this.btExportar.TabIndex = 2;
            this.btExportar.Text = "Salvar uma copia do resultado";
            this.btExportar.UseVisualStyleBackColor = false;
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 596);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.rtRelatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmRelatorio";
            this.Text = "Gastos da viagem";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtRelatorio;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btExportar;
    }
}