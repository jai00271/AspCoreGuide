namespace EFImplementation.Repository.Contracts
{
    using EFImplementation.Repository.DataBase;
    using EFImplementation.Repository.Models;

    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext repositoryContext): base(repositoryContext)
        {

        }
    }
}