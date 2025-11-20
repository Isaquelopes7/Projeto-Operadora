using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Operadora
{
    public partial class Frm2_RecargaParaCelular : Form
    {
        public Frm2_RecargaParaCelular()
        {
            InitializeComponent();
        }

        private void Frm2_RecargaParaCelular_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Finalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Próximo Cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // Mensagem com Condição com dois botoes (sim/nao)
            {     
                Frm_Abertura Finalizar = new Frm_Abertura();
                Finalizar.Show();
                Hide();

            } return;


        }

        private void Rad_Vivo_CheckedChanged(object sender, EventArgs e)
        {
            Txt_OpS.Text = Rad_Vivo.Text;
            Pic_OpS.Image = Properties.Resources.Gif_Vivo;

            BackgroundImage = Properties.Resources.Fundo_Vivo;
            BackgroundImageLayout = ImageLayout.Stretch;
            Txt_ValorRec.Text = null;
            Txt_Status.Text = "Status da venda";
            Msk_Numcel.Enabled = true;
            Pnl_botons.Enabled = true;

            Grp_Dados.ForeColor = Color.White;
            Grp_Operadoras.ForeColor = Color.White;

            Btn_Vl1.Text = "12 Reais";
            Btn_Vl2.Text = "15 Reais";
            Btn_Vl3.Text = "20 Reais";
            Btn_Vl4.Text = "30 Reais";
            Btn_Vl5.Text = "35 Reais";
            Btn_Vl6.Text = "40 Reais";
            Btn_Vl7.Text = "100 Reais";
            Btn_Vl8.Text = "200 Reais";

            Lbl_V1.Text = "30 dias";
            Lbl_V2.Text = "30 dias";
            Lbl_V3.Text = "30 dias";
            Lbl_V4.Text = "30 dias";
            Lbl_V5.Text = "90 dias";
            Lbl_V6.Text = "90 dias";
            Lbl_V7.Text = "180 dias";
            Lbl_V8.Text = "365 dias";

            Btn_Vl1.Enabled = true;
            Btn_Vl2.Enabled = true;
            Btn_Vl3.Enabled = true;
            Btn_Vl4.Enabled = true;
            Btn_Vl5.Enabled = true;
            Btn_Vl6.Enabled = true;
            Btn_Vl7.Enabled = true;
            Btn_Vl8.Enabled = true;

            Btn_Vl1.ForeColor = Color.Purple;
            Btn_Vl2.ForeColor = Color.Purple;
            Btn_Vl3.ForeColor = Color.Purple;
            Btn_Vl4.ForeColor = Color.Purple;
            Btn_Vl5.ForeColor = Color.Purple;
            Btn_Vl6.ForeColor = Color.Purple;
            Btn_Vl7.ForeColor = Color.Purple;
            Btn_Vl8.ForeColor = Color.Purple;



        }

        private void Rad_Claro_CheckedChanged(object sender, EventArgs e)
        {
            Txt_OpS.Text = Rad_Claro.Text;
            Pic_OpS.Image = Properties.Resources.Gif_Claro;
            BackgroundImage = Properties.Resources.Fundo_clrao;
            BackgroundImageLayout = ImageLayout.Stretch;
            Txt_ValorRec.Text = null;
            Txt_Status.Text = "Status da venda";
            Msk_Numcel.Enabled = true;
            Pnl_botons.Enabled = true;

            Grp_Dados.ForeColor = Color.White;
            Grp_Operadoras.ForeColor = Color.White;

            Btn_Vl1.Text = "12 Reais";
            Btn_Vl2.Text = "15 Reais";
            Btn_Vl3.Text = "20 Reais";
            Btn_Vl4.Text = "25 Reais";
            Btn_Vl5.Text = "30 Reais";
            Btn_Vl6.Text = "35 Reais";
            Btn_Vl7.Text = "50 Reais";
            Btn_Vl8.Text = "100 Reais";

            Lbl_V1.Text = "30 dias";
            Lbl_V2.Text = "60 dias";
            Lbl_V3.Text = "60 dias";
            Lbl_V4.Text = "90 dias";
            Lbl_V5.Text = "90 dias";
            Lbl_V6.Text = "90 dias";
            Lbl_V7.Text = "120 dias";
            Lbl_V8.Text = "180 dias";

            Btn_Vl1.Enabled = true;
            Btn_Vl2.Enabled = true;
            Btn_Vl3.Enabled = true;
            Btn_Vl4.Enabled = true;
            Btn_Vl5.Enabled = true;
            Btn_Vl6.Enabled = true;
            Btn_Vl7.Enabled = true;
            Btn_Vl8.Enabled = true;


            Btn_Vl1.ForeColor = Color.Red;
            Btn_Vl2.ForeColor = Color.Red;
            Btn_Vl3.ForeColor = Color.Red;
            Btn_Vl4.ForeColor = Color.Red;
            Btn_Vl5.ForeColor = Color.Red;
            Btn_Vl6.ForeColor = Color.Red;
            Btn_Vl7.ForeColor = Color.Red;
            Btn_Vl8.ForeColor = Color.Red;

        }

        private void Rad_Tim_CheckedChanged(object sender, EventArgs e)
        {
            Txt_OpS.Text = Rad_Tim.Text;
            Pic_OpS.Image = Properties.Resources.Gif_Tim;
            BackgroundImage = Properties.Resources.Fundo_tim;
            BackgroundImageLayout = ImageLayout.Stretch;
            Txt_ValorRec.Text = null;
            Txt_Status.Text = "Status da venda";
            Msk_Numcel.Enabled = true;
            Pnl_botons.Enabled = true;

            Grp_Dados.ForeColor = Color.White;
            Grp_Operadoras.ForeColor = Color.White;

            Btn_Vl1.Text = "10 Reais";
            Btn_Vl2.Text = "15 Reais";
            Btn_Vl3.Text = "20 Reais";
            Btn_Vl4.Text = "30 Reais";
            Btn_Vl5.Text = "40 Reais";
            Btn_Vl6.Text = "50 Reais";
            Btn_Vl7.Text = "60 Reais";
            Btn_Vl8.Text = "100 Reais";

            Lbl_V1.Text = "30 dias";
            Lbl_V2.Text = "30 dias";
            Lbl_V3.Text = "30 dias";
            Lbl_V4.Text = "90 dias";
            Lbl_V5.Text = "90 dias";
            Lbl_V6.Text = "90 dias";
            Lbl_V7.Text = "180 dias";
            Lbl_V8.Text = "180 dias";

            Btn_Vl1.Enabled = true;
            Btn_Vl2.Enabled = true;
            Btn_Vl3.Enabled = true;
            Btn_Vl4.Enabled = true;
            Btn_Vl5.Enabled = true;
            Btn_Vl6.Enabled = true;
            Btn_Vl7.Enabled = true;
            Btn_Vl8.Enabled = true;


            Btn_Vl1.ForeColor = Color.Blue;
            Btn_Vl2.ForeColor = Color.Blue;
            Btn_Vl3.ForeColor = Color.Blue;
            Btn_Vl4.ForeColor = Color.Blue;
            Btn_Vl5.ForeColor = Color.Blue;
            Btn_Vl6.ForeColor = Color.Blue;
            Btn_Vl7.ForeColor = Color.Blue;
            Btn_Vl8.ForeColor = Color.Blue;

        }

        private void Rad_Oi_CheckedChanged(object sender, EventArgs e)
        {
            Txt_OpS.Text = Rad_Oi.Text;
            Pic_OpS.Image = Properties.Resources.Gif_Oi_2;
            BackgroundImage = Properties.Resources.Fundo_Oi;
            Txt_ValorRec.Text = null;
            Txt_Status.Text = "Status da venda";
            Msk_Numcel.Enabled = true;
            Pnl_botons.Enabled = true;

            Grp_Dados.ForeColor = Color.Black;
            Grp_Operadoras.ForeColor = Color.Black;

            Btn_Vl1.Text = "10 Reais";
            Btn_Vl2.Text = "15 Reais";
            Btn_Vl3.Text = "20 Reais";
            Btn_Vl4.Text = "25 Reais";
            Btn_Vl5.Text = "30 Reais";
            Btn_Vl6.Text = "35 Reais";
            Btn_Vl7.Text = "40 Reais";
            Btn_Vl8.Text = "50 Reais";

            Lbl_V1.Text = "30 dias";
            Lbl_V2.Text = "30 dias";
            Lbl_V3.Text = "45 dias";
            Lbl_V4.Text = "45 dias";
            Lbl_V5.Text = "90 dias";
            Lbl_V6.Text = "90 dias";
            Lbl_V7.Text = "90 dias";
            Lbl_V8.Text = "90 dias";

            Btn_Vl1.Enabled = true;
            Btn_Vl2.Enabled = true;
            Btn_Vl3.Enabled = true;
            Btn_Vl4.Enabled = true;
            Btn_Vl5.Enabled = true;
            Btn_Vl6.Enabled = true;
            Btn_Vl7.Enabled = true;
            Btn_Vl8.Enabled = true;


            Btn_Vl1.ForeColor = Color.Yellow;
            Btn_Vl2.ForeColor = Color.Yellow;
            Btn_Vl3.ForeColor = Color.Yellow;
            Btn_Vl4.ForeColor = Color.Yellow;
            Btn_Vl5.ForeColor = Color.Yellow;
            Btn_Vl6.ForeColor = Color.Yellow;
            Btn_Vl7.ForeColor = Color.Yellow;
            Btn_Vl8.ForeColor = Color.Yellow;
        }

        private void Btn_Vl1_Click(object sender, EventArgs e)
        {
            if (Msk_Numcel.MaskCompleted)
            {
                Txt_ValorRec.Text = Btn_Vl1.Text;
                Txt_Status.Text = "Recarga feita com sucesso!!";
                Pnl_botons.Enabled = true;
                Btn_Finalizar.Enabled = true;
                Msk_Numcel.Enabled = false;
            }
            else  //Caso contrário, se não for digitado todos os números do celular
            {
                MessageBox.Show("Digite o Número Completo!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Msk_Numcel.Focus();  // Foca no número
            }
        }

        private void Btn_Vl2_Click(object sender, EventArgs e)
        {
            if (Msk_Numcel.MaskCompleted)
            {
                Txt_ValorRec.Text = Btn_Vl2.Text;
                Txt_Status.Text = "Recarga feita com sucesso!!";
                Pnl_botons.Enabled = true;
                Btn_Finalizar.Enabled = true;
                Msk_Numcel.Enabled = false;
            }
            else  //Caso contrário, se não for digitado todos os números do celular
            {
                MessageBox.Show("Digite o Número Completo!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Msk_Numcel.Focus();  // Foca no número
            }
        }

        private void Btn_Vl3_Click(object sender, EventArgs e)
        {
            if (Msk_Numcel.MaskCompleted)
            {
                Txt_ValorRec.Text = Btn_Vl3.Text;
                Txt_Status.Text = "Recarga feita com sucesso!!";
                Pnl_botons.Enabled = true;
                Btn_Finalizar.Enabled = true;
                Msk_Numcel.Enabled = false;
            }
            else  //Caso contrário, se não for digitado todos os números do celular
            {
                MessageBox.Show("Digite o Número Completo!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Msk_Numcel.Focus();  // Foca no número
            }
        }

        private void Btn_Vl4_Click(object sender, EventArgs e)
        {
            if (Msk_Numcel.MaskCompleted)
            {
                Txt_ValorRec.Text = Btn_Vl4.Text;
                Txt_Status.Text = "Recarga feita com sucesso!!";
                Pnl_botons.Enabled = true;
                Btn_Finalizar.Enabled = true;
                Msk_Numcel.Enabled = false;
            }
            else  //Caso contrário, se não for digitado todos os números do celular
            {
                MessageBox.Show("Digite o Número Completo!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Msk_Numcel.Focus();  // Foca no número
            }
        }

        private void Btn_Vl5_Click(object sender, EventArgs e)
        {
            if (Msk_Numcel.MaskCompleted)
            {
                Txt_ValorRec.Text = Btn_Vl5.Text;
                Txt_Status.Text = "Recarga feita com sucesso!!";
                Pnl_botons.Enabled = true;
                Btn_Finalizar.Enabled = true;
                Msk_Numcel.Enabled = false;
            }
            else  //Caso contrário, se não for digitado todos os números do celular
            {
                MessageBox.Show("Digite o Número Completo!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Msk_Numcel.Focus();  // Foca no número
            }
        }

        private void Btn_Vl6_Click(object sender, EventArgs e)
        {
            if (Msk_Numcel.MaskCompleted)
            {
                Txt_ValorRec.Text = Btn_Vl6.Text;
                Txt_Status.Text = "Recarga feita com sucesso!!";
                Pnl_botons.Enabled = true;
                Btn_Finalizar.Enabled = true;
                Msk_Numcel.Enabled = false;
            }
            else  //Caso contrário, se não for digitado todos os números do celular
            {
                MessageBox.Show("Digite o Número Completo!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Msk_Numcel.Focus();  // Foca no número
            }
        }

        private void Btn_Vl7_Click(object sender, EventArgs e)
        {
            if (Msk_Numcel.MaskCompleted)
            {
                Txt_ValorRec.Text = Btn_Vl7.Text;
                Txt_Status.Text = "Recarga feita com sucesso!!";
                Pnl_botons.Enabled = true;
                Btn_Finalizar.Enabled = true;
                Msk_Numcel.Enabled = false;
            }
            else  //Caso contrário, se não for digitado todos os números do celular
            {
                MessageBox.Show("Digite o Número Completo!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Msk_Numcel.Focus();  // Foca no número
            }
        }

        private void Btn_Vl8_Click(object sender, EventArgs e)
        {
            if (Msk_Numcel.MaskCompleted)
            {
                Txt_ValorRec.Text = Btn_Vl8.Text;
                Txt_Status.Text = "Recarga feita com sucesso!!";
                Pnl_botons.Enabled = true;
                Btn_Finalizar.Enabled = true;
                Msk_Numcel.Enabled = false;
            }
            else  //Caso contrário, se não for digitado todos os números do celular
            {
                MessageBox.Show("Digite o Número Completo!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Msk_Numcel.Focus();  // Foca no número
            }
        }

        private void Btn_Fechar_2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja fechar a aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            return;
        }
    }
}
