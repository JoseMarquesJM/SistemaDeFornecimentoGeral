using FluentValidation;
using FornecimentoGeral.Business.Models.Validations.Documentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornecimentoGeral.Business.Models.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            //When(f => f.TipoFornecedo == TipoFornecedor.PessoaFisica, () =>
            //{
            //    RuleFor(f => f.Documento.Length)
            //    .Equals(CpfValidacao.TamanhoCpf)
            //    .WithMessage("")
            //});
        }
    }
}
