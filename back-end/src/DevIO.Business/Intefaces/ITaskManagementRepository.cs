using DevIO.Business.Models;

namespace DevIO.Business.Intefaces
{
    public interface ITaskManagementRepository : IRepository<Models.TaskManagement>
    {
        //Task<Task> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}