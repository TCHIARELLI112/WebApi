using System.Threading.Tasks;
using PrimeiroProjetoWebApi.models;
using Microsoft.EntityFrameworkCore;


namespace PrimeiroProjetoWebApi.Data
{

    public class Repository : IRepository
    {

        
    private readonly DataContext _context;

    public Repository(DataContext context)
    {

    }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public Task<Aluno[]> GetAllAlunosAsync(bool includeProfessor)
        {
            throw new System.NotImplementedException();
        }

        public Task<Professor[]> GetAllProfessorAsync(bool includeAluno)
        {
            throw new System.NotImplementedException();
        }

        public Task<Aluno[]> GetAlunosAsyncByDisciplinaId(int disciplinaId, bool includeDisciplina)
        {
            throw new System.NotImplementedException();
        }

        public Task<Aluno[]> GetAlunosAsyncById(int AlunoId, bool includeProfessor)
        {
            throw new System.NotImplementedException();
        }

        public Task<Professor[]> GetProfessorAsyncByAlunoId(int AlunoId, bool includeDisciplina)
        {
            throw new System.NotImplementedException();
        }

        public Task<Professor[]> GetProfessorAsyncById(int professorId, bool includeAluno)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
            
        }

        public void Update<T>(T entity) where T : class
        {
           _context.Update(entity);
        }
    }
}