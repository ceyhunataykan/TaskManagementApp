using CA.TaskManagement.Business.Interfaces;
using CA.TaskManagement.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using CA.TaskManagement.Entities.Concrete;
using System.Collections.Generic;

namespace CA.TaskManagement.Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        private readonly EfKullaniciRepository efKullaniciRepository;

        public KullaniciManager()
        {
            efKullaniciRepository = new EfKullaniciRepository();
        }
        public Kullanici GetirId(int id)
        {
            return efKullaniciRepository.GetirId(id);
        }

        public List<Kullanici> GetirTum()
        {
            return efKullaniciRepository.GetirTum();
        }

        public void Guncelle(Kullanici tablo)
        {
            efKullaniciRepository.Guncelle(tablo);
        }

        public void Kaydet(Kullanici tablo)
        {
            efKullaniciRepository.Kaydet(tablo);
        }

        public void Sil(Kullanici tablo)
        {
            efKullaniciRepository.Sil(tablo);
        }
    }
}
