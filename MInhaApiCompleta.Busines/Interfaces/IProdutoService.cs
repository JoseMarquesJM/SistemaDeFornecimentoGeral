using System;
using System.Threading.Tasks;
using FornecimentoGeral.Business.Models;

namespace DevIO.Business.Intefaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}