using System;
using System.Collections.Generic;
using System.Text;

namespace EFImplementation.Repository.Contracts
{
    public interface IRepositoryWrapper
    {
        IOwnerRepository Owner { get; }
        IAccountRepository Account { get; }
    }
}
