namespace Projeto_Viagem
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lbDistancia = new System.Windows.Forms.Label();
            this.lbConsumo = new System.Windows.Forms.Label();
            this.lbCombustivel = new System.Windows.Forms.Label();
            this.lbPegadio = new System.Windows.Forms.Label();
            this.ckGastoPedagio = new System.Windows.Forms.CheckBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtCombustivel = new System.Windows.Forms.TextBox();
            this.txtPedagio = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbKm = new System.Windows.Forms.Label();
            this.lbKml = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.BackColor = System.Drawing.Color.Transparent;
            this.lbDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistancia.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbDistancia.Location = new System.Drawing.Point(26, 34);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(182, 22);
            this.lbDistancia.TabIndex = 0;
            this.lbDistancia.Text = "Distância a percorrer:";
            // 
            // lbConsumo
            // 
            this.lbConsumo.AutoSize = true;
            this.lbConsumo.BackColor = System.Drawing.Color.Transparent;
            this.lbConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsumo.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbConsumo.Location = new System.Drawing.Point(26, 79);
            this.lbConsumo.Name = "lbConsumo";
            this.lbConsumo.Size = new System.Drawing.Size(230, 22);
            this.lbConsumo.TabIndex = 1;
            this.lbConsumo.Text = "Consumo medio do veiculo:";
            // 
            // lbCombustivel
            // 
            this.lbCombustivel.AutoSize = true;
            this.lbCombustivel.BackColor = System.Drawing.Color.Transparent;
            this.lbCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCombustivel.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbCombustivel.Location = new System.Drawing.Point(26, 124);
            this.lbCombustivel.Name = "lbCombustivel";
            this.lbCombustivel.Size = new System.Drawing.Size(213, 22);
            this.lbCombustivel.TabIndex = 2;
            this.lbCombustivel.Text = "Valor do Combustivel R$:";
            // 
            // lbPegadio
            // 
            this.lbPegadio.AutoSize = true;
            this.lbPegadio.BackColor = System.Drawing.Color.Transparent;
            this.lbPegadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPegadio.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbPegadio.Location = new System.Drawing.Point(26, 216);
            this.lbPegadio.Name = "lbPegadio";
            this.lbPegadio.Size = new System.Drawing.Size(250, 22);
            this.lbPegadio.TabIndex = 3;
            this.lbPegadio.Text = "Valor gasto com pedagios R$:";
            this.lbPegadio.Visible = false;
            // 
            // ckGastoPedagio
            // 
            this.ckGastoPedagio.AutoSize = true;
            this.ckGastoPedagio.BackColor = System.Drawing.Color.Transparent;
            this.ckGastoPedagio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckGastoPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckGastoPedagio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ckGastoPedagio.Location = new System.Drawing.Point(27, 169);
            this.ckGastoPedagio.Name = "ckGastoPedagio";
            this.ckGastoPedagio.Size = new System.Drawing.Size(254, 24);
            this.ckGastoPedagio.TabIndex = 7;
            this.ckGastoPedagio.Text = "Houve gastos com pedagios";
            this.ckGastoPedagio.UseVisualStyleBackColor = false;
            this.ckGastoPedagio.CheckedChanged += new System.EventHandler(this.ckGastoPedagio_CheckedChanged);
            // 
            // txtDistancia
            // 
            this.txtDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.Location = new System.Drawing.Point(273, 31);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 27);
            this.txtDistancia.TabIndex = 8;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumo.Location = new System.Drawing.Point(273, 76);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 27);
            this.txtConsumo.TabIndex = 9;
            // 
            // txtCombustivel
            // 
            this.txtCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombustivel.Location = new System.Drawing.Point(273, 124);
            this.txtCombustivel.Name = "txtCombustivel";
            this.txtCombustivel.Size = new System.Drawing.Size(100, 27);
            this.txtCombustivel.TabIndex = 10;
            // 
            // txtPedagio
            // 
            this.txtPedagio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedagio.Location = new System.Drawing.Point(273, 213);
            this.txtPedagio.Name = "txtPedagio";
            this.txtPedagio.Size = new System.Drawing.Size(100, 27);
            this.txtPedagio.TabIndex = 11;
            this.txtPedagio.Visible = false;
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.Maroon;
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btCalcular.Location = new System.Drawing.Point(139, 263);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(246, 29);
            this.btCalcular.TabIndex = 12;
            this.btCalcular.Text = "Calcular Gastos";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbKm
            // 
            this.lbKm.AutoSize = true;
            this.lbKm.BackColor = System.Drawing.Color.Transparent;
            this.lbKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKm.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbKm.Location = new System.Drawing.Point(379, 36);
            this.lbKm.Name = "lbKm";
            this.lbKm.Size = new System.Drawing.Size(36, 22);
            this.lbKm.TabIndex = 13;
            this.lbKm.Text = "Km";
            // 
            // lbKml
            // 
            this.lbKml.AutoSize = true;
            this.lbKml.BackColor = System.Drawing.Color.Transparent;
            this.lbKml.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKml.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbKml.Location = new System.Drawing.Point(379, 79);
            this.lbKml.Name = "lbKml";
            this.lbKml.Size = new System.Drawing.Size(51, 22);
            this.lbKml.TabIndex = 14;
            this.lbKml.Text = "Km/L";
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.DarkRed;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btLimpar.Location = new System.Drawing.Point(391, 263);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(73, 29);
            this.btLimpar.TabIndex = 15;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(511, 349);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.lbKml);
            this.Controls.Add(this.lbKm);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtPedagio);
            this.Controls.Add(this.txtCombustivel);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.ckGastoPedagio);
            this.Controls.Add(this.lbPegadio);
            this.Controls.Add(this.lbCombustivel);
            this.Controls.Add(this.lbConsumo);
            this.Controls.Add(this.lbDistancia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Gasto da Viagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Label lbConsumo;
        private System.Windows.Forms.Label lbCombustivel;
        private System.Windows.Forms.Label lbPegadio;
        private System.Windows.Forms.CheckBox ckGastoPedagio;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtCombustivel;
        private System.Windows.Forms.TextBox txtPedagio;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbKm;
        private System.Windows.Forms.Label lbKml;
        private System.Windows.Forms.Button btLimpar;
    }
}

