using CA.TaskManagement.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.TaskManagement.Business.Interfaces
{
    public interface IGenericService<Tablo> where Tablo:class, ITable, new()
    {
        void Sil(Tablo tablo);
        void Kaydet(Tablo tablo);
        void Guncelle(Tablo tablo);
        Tablo GetirId(int id);
        List<Tablo> GetirTum();
    }
}
