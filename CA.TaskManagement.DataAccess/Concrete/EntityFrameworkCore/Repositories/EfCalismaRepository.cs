using CA.TaskManagement.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using CA.TaskManagement.DataAccess.Interfaces;
using CA.TaskManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CA.TaskManagement.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCalismaRepository : EfGenericRepository<Calisma>, ICalismaDal
    {

    }
}
