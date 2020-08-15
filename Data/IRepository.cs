using System.Threading.Tasks;
using PrimeiroProjetoWebApi.models;



namespace PrimeiroProjetoWebApi.Data
{
    public interface IRepository
    {

        //Geral
        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool>SaveChangesAsync();

        //Aluno
        Task<Aluno[]> GetAllAlunosAsync(bool includeProfessor);
        Task<Aluno[]> GetAlunosAsyncByDisciplinaId(int disciplinaId,bool includeDisciplina);
        Task<Aluno[]> GetAlunosAsyncById(int AlunoId, bool includeProfessor);

        //Professo
        Task<Professor[]> GetAllProfessorAsync (bool includeAluno);
        Task<Professor[]> GetProfessorAsyncByAlunoId (int AlunoId, bool includeDisciplina);
        Task<Professor[]> GetProfessorAsyncById(int professorId, bool includeAluno);



        
    }
}