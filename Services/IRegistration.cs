using Exam.Data;
using Exam.Models;

namespace Exam.Services
{
    public interface IRegistration
    {
        public Task<IEnumerable<Registration>> GetAll();
        Task<Registration> Create(Registration registration);
        Task<Registration> GetById(int id);
        Task Update(Registration registration);
        Task Delete(int id);
    }
}
