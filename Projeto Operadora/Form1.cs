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
    public partial class Frm_Abertura: Form
    {
        public Frm_Abertura()
        {
            InitializeComponent();
        }

        string regiao;

        private void Rad_Es_CheckedChanged(object sender, EventArgs e)
        {
            regiao = Rad_Es.Text;
            Pic_estado.Image = Properties.Resources.Bandeira_do_Espírito_Santo;
            Txt_RgS.Text = Rad_Es.Text;
            Txt_Ddd.Text = "27";
        }

        private void Rad_Mg_CheckedChanged(object sender, EventArgs e)
        {
            regiao = Rad_Mg.Text;
            Pic_estado.Image = Properties.Resources.bandeira_de_minas_gerais;
            Txt_RgS.Text = Rad_Mg.Text;
            Txt_Ddd.Text = "31";
        }

        private void Rad_Rj_CheckedChanged(object sender, EventArgs e)
        {
            regiao = Rad_Rj.Text;
            Pic_estado.Image = Properties.Resources.Bandeira_do_estado_do_Rio_de_Janeiro;
            Txt_RgS.Text = Rad_Rj.Text;
            Txt_Ddd.Text = "21";

        }

        private void Rad_Sp_CheckedChanged(object sender, EventArgs e)
        {
            regiao = Rad_Sp.Text;
            Pic_estado.Image = Properties.Resources.Bandeira_do_estado_de_São_Paulo;
            Txt_RgS.Text = Rad_Sp.Text;
            Txt_Ddd.Text = "11";

        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            // Usando a Estrutura Condicional Composta (IF/ELSE) para ter 2 respostas

            if(Rad_Es.Checked || Rad_Mg.Checked || Rad_Rj.Checked || Rad_Sp.Checked){   // O ( || ) também da para digitar com uma barra ( | )

                string usuario = Txt_Nm.Text;

                MessageBox.Show($"Olá, {usuario}! A sua região é {regiao}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Frm2_RecargaParaCelular confirmar = new Frm2_RecargaParaCelular();
                confirmar.Lbl_Nm_2.Text = Txt_Nm.Text;
                confirmar.Txt_Rg.Text = Txt_RgS.Text;
                confirmar.Txt_Ddd_2.Text = Txt_Ddd.Text;
                confirmar.Show();
                Hide();

                

            }
            else  // Caso contrário, se não selecionar nenhuma das regiões
            {
                MessageBox.Show("Selecione uma região!" , "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);  // Mensagem de Aviso. 
            }


        }

        private void Frm_abertura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Nm_TextChanged(object sender, EventArgs e)
        {
            Lbl_Caracteres.Text = (Txt_Nm.MaxLength - Txt_Nm.TextLength).ToString() + " caracteres";  // O Label esta recebendo a conversão do cálculo da contagem de caracteres

            if(Lbl_Caracteres.Text == "30 caracteres")
            {
                Lbl_Caracteres.Text = "No Mínimo 2 caracteres.";
            }

            if(Txt_Nm.TextLength >= 2) // Condição para digitar no mínimo 2 caracteres
            {
                Btn_Confirmar.Visible = true; // Mostrando o Botão Confirmar

            } else if (Txt_Nm.TextLength <= 2)  // Caso contrário, se for menos de 2 caracteres
            {
                Btn_Confirmar.Visible = false;  // Escondendo o Botão Confirmar
            }
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja fechar a aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // Uma mensagem com condição
            {
                Application.Exit();
            }
            Txt_Nm.Focus();  // Habilita de volta o 'pisque' do cursor.
        }

        private void Txt_Nm_KeyPress(object sender, KeyPressEventArgs e)   // O (e) é uma variável do próprio código
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar) != ' ' )// Permitindo apenas letras.
            {
                e.Handled = true;    // Verificando se as teclas pressionadas foram letras
                MessageBox.Show("Digite somente letras!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
            } 
        }
    }
}
