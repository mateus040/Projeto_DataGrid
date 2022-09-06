namespace Importar_Marcar
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
            this.btn_Importar = new System.Windows.Forms.Button();
            this.btn_Marcar = new System.Windows.Forms.Button();
            this.btn_Desmarcar = new System.Windows.Forms.Button();
            this.dvg_despesa = new System.Windows.Forms.DataGridView();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_despesa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Importar
            // 
            this.btn_Importar.Location = new System.Drawing.Point(22, 12);
            this.btn_Importar.Name = "btn_Importar";
            this.btn_Importar.Size = new System.Drawing.Size(201, 53);
            this.btn_Importar.TabIndex = 0;
            this.btn_Importar.Text = "Importar Arquivo";
            this.btn_Importar.UseVisualStyleBackColor = true;
            this.btn_Importar.Click += new System.EventHandler(this.btn_Importar_Click);
            // 
            // btn_Marcar
            // 
            this.btn_Marcar.Location = new System.Drawing.Point(917, 29);
            this.btn_Marcar.Name = "btn_Marcar";
            this.btn_Marcar.Size = new System.Drawing.Size(120, 36);
            this.btn_Marcar.TabIndex = 1;
            this.btn_Marcar.Text = "Marcar Todos";
            this.btn_Marcar.UseVisualStyleBackColor = true;
            this.btn_Marcar.Click += new System.EventHandler(this.btn_Marcar_Click);
            // 
            // btn_Desmarcar
            // 
            this.btn_Desmarcar.Location = new System.Drawing.Point(1078, 29);
            this.btn_Desmarcar.Name = "btn_Desmarcar";
            this.btn_Desmarcar.Size = new System.Drawing.Size(120, 36);
            this.btn_Desmarcar.TabIndex = 2;
            this.btn_Desmarcar.Text = "Desmarcar Todos";
            this.btn_Desmarcar.UseVisualStyleBackColor = true;
            this.btn_Desmarcar.Click += new System.EventHandler(this.btn_Desmarcar_Click);
            // 
            // dvg_despesa
            // 
            this.dvg_despesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_despesa.Location = new System.Drawing.Point(25, 83);
            this.dvg_despesa.Name = "dvg_despesa";
            this.dvg_despesa.Size = new System.Drawing.Size(1173, 480);
            this.dvg_despesa.TabIndex = 3;
            this.dvg_despesa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_despesa_CellClick);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 638);
            this.Controls.Add(this.dvg_despesa);
            this.Controls.Add(this.btn_Desmarcar);
            this.Controls.Add(this.btn_Marcar);
            this.Controls.Add(this.btn_Importar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_despesa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Importar;
        private System.Windows.Forms.Button btn_Marcar;
        private System.Windows.Forms.Button btn_Desmarcar;
        private System.Windows.Forms.DataGridView dvg_despesa;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

