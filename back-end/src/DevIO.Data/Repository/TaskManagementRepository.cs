using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DevIO.Data.Repository
{
    public class TaskManagementRepository : Repository<Business.Models.TaskManagement>, ITaskManagementRepository
    {
        public TaskManagementRepository(MeuDbContext context) : base(context) { }

    }
}