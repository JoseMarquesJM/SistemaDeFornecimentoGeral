using FornecimentoGeral.Business.Models;
using System.ComponentModel.DataAnnotations;

namespace FornecimentoGeral.Api.DTOs
{
    public class FornecedorInputModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="O campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedo { get; set; }
        public EnderecoInputModel Endereco { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<ProdutoInputModel> Produtos { get; set; }
    }
}
