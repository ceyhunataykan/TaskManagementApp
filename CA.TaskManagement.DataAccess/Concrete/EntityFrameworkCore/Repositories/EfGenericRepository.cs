using CA.TaskManagement.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using CA.TaskManagement.DataAccess.Interfaces;
using CA.TaskManagement.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA.TaskManagement.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<Tablo> : IGenericDal<Tablo> where Tablo : class, ITable, new()
    {
        public Tablo GetirId(int id)
        {
            using var context = new TaskManagementContext();
            return context.Set<Tablo>().Find(id);
        }

        public List<Tablo> GetirTum()
        {
            using var context = new TaskManagementContext();
            return context.Set<Tablo>().ToList();
        }

        public void Guncelle(Tablo tablo)
        {
            using var context = new TaskManagementContext();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();
        }

        public void Kaydet(Tablo tablo)
        {
            using var context = new TaskManagementContext();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();
        }

        public void Sil(Tablo tablo)
        {
            using var context = new TaskManagementContext();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }
    }
}
