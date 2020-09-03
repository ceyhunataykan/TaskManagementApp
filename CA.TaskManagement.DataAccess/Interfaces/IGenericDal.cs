using System;
using System.Collections.Generic;
using System.Text;
using CA.TaskManagement.Entities.Interfaces;

namespace CA.TaskManagement.DataAccess.Interfaces
{
    public interface IGenericDal<Tablo> where Tablo : class, ITable, new()
    {
        void Sil(Tablo tablo);
        void Kaydet(Tablo tablo);
        void Guncelle(Tablo tablo);
        Tablo GetirId(int id);
        List<Tablo> GetirTum();
    }
}
