using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJETOCRUD
{
    class dal
    {

        public void Adicionar(Construtor mo)
        {
           
            String caminhodb = "Server=127.0.0.1;DATABASE=projeto_crud_java;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(caminhodb);//tentar uma conexao
                conexao.Open(); //abrir banco
                string adicionar = "insert into cad_aluno(nome,endereco,cidade,bairro,estado,cep,fone,cel,estadocivil,email,obs,login,password)" +
                "values('" + mo.nome + "','" + mo.endereco + "','" + mo.cidade + "','" + mo.bairro + "','" + mo.estado + "','" + mo.cep + "','" + mo.fone + "','" + mo.cel + "','" + mo.estadocivil + "','" + mo.email + "','" + mo.obs + "','" + mo.login + "','" + mo.password + "')";
                MySqlCommand command = new MySqlCommand(adicionar, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();

            }
            catch(Exception ex) //Exceção 
            {
               
                throw new Exception("Erro de comandos" + ex.Message); 
            
            }
        }

        public void Alterar(Construtor mo)
        {
            String con = "Server=127.0.0.1;DATABASE=projeto_crud_java;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(con);
                conexao.Open();
                string alterar = "update cad_aluno set id_alunos='" + mo.id + "',nome = '" + mo.nome + "',endereco='" + mo.endereco + "',cidade='" + mo.cidade +"',bairro='"+mo.bairro+"',estado='"+mo.estado+"',cep='"+mo.cep+"',fone='"+mo.fone+"',cel='"+mo.cel+"',estadocivil='"+mo.estadocivil+"',email='"+mo.email+"',obs='"+mo.obs+"',login='"+mo.login+"',password='"+mo.password+ "'where id_alunos='" + mo.id + "';";
                MySqlCommand command = new MySqlCommand(alterar, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Comando " + ex.Message);
            }
        }

        public void Deletar(Construtor mo)
        {
            String con = "Server=127.0.0.1;DATABASE=projeto_crud_java;UID=root;PASSWORD=";
            try
            {
                MySqlConnection conexao = new MySqlConnection(con);
                conexao.Open();

                string delete = "delete from cad_aluno where id_alunos='" + mo.id + "';";
                MySqlCommand command = new MySqlCommand(delete, conexao);
                MySqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de Comando " + ex.Message);
            }
        }
    }
}
