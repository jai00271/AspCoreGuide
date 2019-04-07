namespace EFImplementation.Repository.Contracts
{
    using EFImplementation.Repository.DataBase;
    using EFImplementation.Repository.Models;

    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}