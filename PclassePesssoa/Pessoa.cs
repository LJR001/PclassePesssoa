using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PclassePesssoa
{
    internal class Pessoa
    {
        String nome;
        String data_nasc;
        String cpf;
        String telefone;

        public Pessoa(String nome, String data_nasc, String cpf, String telefone)
        {
            this.nome = nome;
            this.data_nasc = data_nasc;
            this.cpf = cpf;
            this.telefone = telefone;
        }

        public override string ToString()
        {
            return "Nome: " + nome + "\ndata de nascimento: " + data_nasc + "\ncpf: " + cpf + "\ntelefone " + telefone;
        }

       
        public String getNome()
        {
               return nome;
        }
        public String getDataNasc()
        {
            return data_nasc;
        }
        public String getCpf()
        {
              return cpf;
        }
        public String getTelefone()
        {
            return telefone;
        }


    }
}
