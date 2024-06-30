using AutoMapper;
using FornecimentoGeral.Api.DTOs;
using FornecimentoGeral.Business.Models;

namespace FornecimentoGeral.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Fornecedor, FornecedorInputModel>().ReverseMap();
            CreateMap<Produto, ProdutoInputModel>().ReverseMap();
            CreateMap<Endereco, EnderecoInputModel>().ReverseMap();
        }
    }
}
