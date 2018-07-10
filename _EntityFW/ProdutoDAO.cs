using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EntityFW
{
    class ProdutoDAO : IDisposable
    {
        private IDbConnection conexao;
        public ProdutoDAO()
        {
            this.conexao = new System.Data.SqlClient
                .SqlConnection("Data Source=DESKTOP-K6073DO;Initial Catalog=HondaFitParts;Persist Security Info=True;User ID=sa;Password=asdasd");
            this.conexao.Open();
        }
        internal void Adicionar(Produto produto)
        {
            throw new NotImplementedException();
        }
        internal void Atualizar(Produto produto)
        {
            throw new NotImplementedException();
        }
        internal void Remover(Produto produto)
        {
            throw new NotImplementedException();
        }
        internal void Produtos()
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            this.conexao.Close();
        }
    }
}
