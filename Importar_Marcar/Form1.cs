using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Importar_Marcar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double venda_porcentagem, selecao, desconto;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cria as coluunas definindo o tipo de cada uma
            dvg_despesa.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dvg_despesa.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dvg_despesa.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dvg_despesa.Columns.Insert(3, new DataGridViewTextBoxColumn());
            dvg_despesa.Columns.Insert(4, new DataGridViewTextBoxColumn());
            dvg_despesa.Columns.Insert(5, new DataGridViewTextBoxColumn());

            // Renomeia as colunas
            dvg_despesa.Columns[0].Name = "OK";
            dvg_despesa.Columns[1].Name = "CODIGO";
            dvg_despesa.Columns[2].Name = "PRODUTO";
            dvg_despesa.Columns[3].Name = "VALOR_COMPRA";
            dvg_despesa.Columns[4].Name = "VALOR_VENDA";
            dvg_despesa.Columns[5].Name = "ESTOQUE";

            // Configura a DataGridView
            dvg_despesa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dvg_despesa.ReadOnly = true;
            dvg_despesa.AllowUserToAddRows = false;
            dvg_despesa.AllowUserToDeleteRows = false;
            dvg_despesa.AllowUserToOrderColumns = true;

            // Configura a coluna de valor formatando e alinhado
            dvg_despesa.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dvg_despesa.Columns[3].DefaultCellStyle.Format = "###,###,##0.00";

            dvg_despesa.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dvg_despesa.Columns[4].DefaultCellStyle.Format = "###,###,##0.00";

        }



        private void btn_Importar_Click(object sender, EventArgs e)
        {
            dvg_despesa.RowCount = 0;

            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();

            StreamReader arquivo = File.OpenText(ofdArquivo.FileName);

            String linha;
            while ((linha = arquivo.ReadLine()) != null)
            {
                string[] dados = linha.Split(';');
                int codigo = int.Parse(dados[0]);
                string produto = dados[1];
                double valor_compra = double.Parse(dados[2]);
                double valor_venda = double.Parse(dados[3]);
                int estoque = int.Parse(dados[4]);

                dvg_despesa.Rows.Add(false, codigo, produto, valor_compra, valor_venda, estoque);

                dvg_despesa.DefaultCellStyle.Font = new Font(dvg_despesa.Font, FontStyle.Bold);

                foreach (DataGridViewRow dvg_linha in dvg_despesa.Rows)
                if (Convert.ToDouble(dvg_linha.Cells[4].Value) < Convert.ToDouble(dvg_linha.Cells[3].Value))
                    {
                        dvg_despesa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dvg_despesa.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                        dvg_despesa.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
                    }
            }

        }

        private void dvg_despesa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvg_despesa.RowCount > 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dvg_despesa.CurrentRow.Cells[0].Value) == false)
                {
                    dvg_despesa.CurrentRow.Cells[0].Value = true;
                    selecao += Convert.ToDouble(dvg_despesa.CurrentRow.Cells[4].Value);
                }
                else
                {
                    dvg_despesa.CurrentRow.Cells[0].Value = false;
                    selecao -= Convert.ToDouble(dvg_despesa.CurrentRow.Cells[4].Value);
                    
                }
                lbl_selecao.Text = selecao.ToString("C");
            }
        }


        private void btn_Marcar_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow linha in dvg_despesa.Rows)
            {
                linha.Cells[0].Value = true;
                selecao += Convert.ToDouble(linha.Cells[4].Value);
            }
            lbl_selecao.Text = selecao.ToString("C");

        }

        private void btn_porcentagem_Click(object sender, EventArgs e)
        {
            desconto = 20; //Porcentagem

            venda_porcentagem = selecao - (selecao * (desconto / 100));

            lbl_desconto.Text = venda_porcentagem.ToString("C");
        }


        private void btn_Desmarcar_Click(object sender, EventArgs e)
        {
            selecao = 0;
            venda_porcentagem = 0;
            foreach (DataGridViewRow linha in dvg_despesa.Rows)
                linha.Cells[0].Value = false;
            lbl_selecao.Text = selecao.ToString("C");
            lbl_desconto.Text = venda_porcentagem.ToString("C");

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            dvg_despesa.Rows.Clear();
            lbl_selecao.Text = "R$ 0,00";
            lbl_desconto.Text = "R$ 0,00";
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
