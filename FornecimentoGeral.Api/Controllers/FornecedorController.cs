using AutoMapper;
using DevIO.Business.Intefaces;
using FornecimentoGeral.Api.DTOs;
using FornecimentoGeral.Business.Interfaces;
using FornecimentoGeral.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FornecimentoGeral.Api.Controllers;

[Route("api/[controller]")]
public class FornecedorController : MainController
{
    private readonly IFornecedorRepository _fornecedorRepository;
    private readonly IFornecedorService _fornecedorService;
    private readonly IMapper _mapper;

    public FornecedorController(IFornecedorRepository fornecedorRepository,
                                IMapper mapper,
                                IFornecedorService fornecedorService)
    {
        _fornecedorRepository = fornecedorRepository;
        _mapper = mapper;
        _fornecedorService = fornecedorService;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<FornecedorInputModel>>> ObterTodos() 
    {
        var fornecedor = _mapper.Map<IEnumerable<FornecedorInputModel>>(await _fornecedorRepository.ObterTodos());
        return Ok(fornecedor);
    } 

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<FornecedorInputModel>> ObterPorId(Guid id) 
    {
        var fornecedor = _mapper.Map<FornecedorInputModel>(await 
            _fornecedorRepository.ObterFornecedorProdutosEndereco(id));

        if (fornecedor is null) return NotFound();

        return fornecedor;
    }

    [HttpPost]
    public async Task<ActionResult<FornecedorInputModel>> Adicionar(FornecedorInputModel fornecedorInputModel)
    {
       if(!ModelState.IsValid) return BadRequest();

        var fornecedor = _mapper.Map<Fornecedor>(fornecedorInputModel);
        var result = await _fornecedorService.Adicionar(fornecedor);

        if(!result) return BadRequest();

        return Created(nameof(ObterTodos), fornecedor);
    }

    [HttpPut("{id:guid}")]
    public async Task<ActionResult<FornecedorInputModel>> Atualizar(Guid id, FornecedorInputModel fornecedorInputModel)
    {
        if(id != fornecedorInputModel.Id) return BadRequest();
        if (!ModelState.IsValid) return BadRequest();

        var fornecedor = _mapper.Map<Fornecedor>(fornecedorInputModel);
        var result = await _fornecedorService.Atualizar(fornecedor);

        if (!result) return BadRequest();

        return Ok(fornecedor);
    }
}
