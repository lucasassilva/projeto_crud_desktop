using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETOCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            comboUF.SelectedIndex = -1;
            comboCivil.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            textBairro.Clear();
            textCidade.Clear();
            textCod.Clear();
            textEnd.Clear();
            textNome.Clear();
            textLogin.Clear();
            textObs.Clear();
            textSenha.Clear();
            textEmail.Clear();
            maskedFone.Clear();
            maskedCep.Clear();
            maskedCelular.Clear();
            
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "" || textCidade.Text == "" || textBairro.Text == "" || textEmail.Text == "" || textSenha.Text == "" || textObs.Text == "" || textEnd.Text == "" || comboUF.Text == "" || comboCivil.Text == "" || maskedCep.Text == "" || maskedCelular.Text == "" || maskedFone.Text == "" || textLogin.Text == "" || textSenha.Text == "")
            {
                MessageBox.Show("Prencha todos os campos");
            }
            else
            {
                Construtor mo = new Construtor();
                dal da = new dal();

                mo.nome = textNome.Text;
                mo.endereco = textEnd.Text;
                mo.cidade = textCidade.Text;
                mo.bairro = textBairro.Text;
                mo.estado = comboUF.Text;
                mo.cep = maskedCep.Text;
                mo.fone = maskedFone.Text;
                mo.cel = maskedCelular.Text;
                mo.estadocivil = comboCivil.Text;
                mo.email = textEmail.Text;
                mo.obs = textObs.Text;
                mo.login = textLogin.Text;
                mo.password = textSenha.Text;

                da.Adicionar(mo);

                MessageBox.Show("Dados gravados com suceeso");

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "" || textCidade.Text == "" || textBairro.Text == "" || textEmail.Text == "" || textSenha.Text == "" || textObs.Text == "" || textEnd.Text == "" || comboUF.Text == "" || comboCivil.Text == ""||maskedCep.Text==""||maskedCelular.Text==""||maskedFone.Text==""||textLogin.Text==""||textSenha.Text=="")
            {
                MessageBox.Show("Altere todos os campos");
            }
            else
            {
                Construtor mo = new Construtor();
                dal da = new dal();
                mo.id = Convert.ToInt16(textCod.Text);
                mo.nome = textNome.Text;
                mo.endereco = textEnd.Text;
                mo.cidade = textCidade.Text;
                mo.bairro = textBairro.Text;
                mo.estado = comboUF.Text;
                mo.cep = maskedCep.Text;
                mo.fone = maskedFone.Text;
                mo.cel = maskedCelular.Text;
                mo.estadocivil = comboCivil.Text;
                mo.email = textEmail.Text;
                mo.obs = textObs.Text;
                mo.login = textLogin.Text;
                mo.password = textSenha.Text;
                da.Alterar(mo);
                MessageBox.Show("Dados alterados com suceeso");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textCod.Text == "")
            {
                MessageBox.Show("Codigo Incorreto");
            }
            else
            {
                Construtor mo = new Construtor();
                dal da = new dal();
                mo.id = Convert.ToInt16(textCod.Text);
                mo.nome = textNome.Text;
                mo.endereco = textEnd.Text;
                mo.cidade = textCidade.Text;
                mo.bairro = textBairro.Text;
                mo.estado = comboUF.Text;
                mo.cep = maskedCep.Text;
                mo.fone = maskedFone.Text;
                mo.cel = maskedCelular.Text;
                mo.estadocivil = comboCivil.Text;
                mo.email = textEmail.Text;
                mo.obs = textObs.Text;
                mo.login = textLogin.Text;
                mo.password = textSenha.Text;
                da.Deletar(mo);
                MessageBox.Show("Dados deletados com suceeso");

            }
        }

        private void maskedCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
