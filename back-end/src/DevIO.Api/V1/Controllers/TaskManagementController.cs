using AutoMapper;
using DevIO.Api.Extensions;
using DevIO.Api.ViewModels;
using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.V1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskManagementController : ControllerBase
    {
        private readonly ITaskManagementRepository _taskManagementRepository;
        private readonly IMapper _mapper;

        public TaskManagementController(IMapper mapper, 
                                      ITaskManagementRepository taskManagementRepository
                                     ) 
        {
            _taskManagementRepository = taskManagementRepository;
            _mapper = mapper;
        }

        //[AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<TaskManagementViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<TaskManagementViewModel>>(await _taskManagementRepository.ObterTodos());
        }

        [HttpGet("{id}")]
        public async Task<TaskManagement> Get(Guid id)
        {
            return await _taskManagementRepository.ObterPorId(id);
        }

        [HttpPost]
        public async Task<TaskManagement> Post([FromBody] TaskManagement model)
        {
            await _taskManagementRepository.Adicionar(model);
            return model;
        }

        [HttpPut("{id}")]
        public async Task<TaskManagement> Put(Guid id, [FromBody] TaskManagement domain)
        {
        
            var resposta = _taskManagementRepository.Atualizar(domain);

            return domain;
        }

        [HttpDelete("{id}")]
        public async Task<TaskManagement> Delete(Guid id)
        {
            var endereco = _taskManagementRepository.ObterPorId(id).Result;
            var resposta = _taskManagementRepository.Remover(id);
            return endereco;
        }
    }
}