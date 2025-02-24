﻿using System;
using System.Threading.Tasks;
using FornecimentoGeral.Business.Interfaces;
using FornecimentoGeral.Business.Models;

namespace DevIO.Business.Intefaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}