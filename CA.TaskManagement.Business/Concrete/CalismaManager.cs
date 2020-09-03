using CA.TaskManagement.Business.Interfaces;
using CA.TaskManagement.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using CA.TaskManagement.Entities.Concrete;
using System.Collections.Generic;

namespace CA.TaskManagement.Business.Concrete
{
    class CalismaManager : ICalismaService
    {
        private readonly EfCalismaRepository efCaslimaRepository;

        public CalismaManager()
        {
            efCaslimaRepository = new EfCalismaRepository();
        }
        public Calisma GetirId(int id)
        {
            return efCaslimaRepository.GetirId(id);
        }

        public List<Calisma> GetirTum()
        {
            return efCaslimaRepository.GetirTum();
        }

        public void Guncelle(Calisma tablo)
        {
            efCaslimaRepository.Guncelle(tablo);
        }

        public void Kaydet(Calisma tablo)
        {
            efCaslimaRepository.Kaydet(tablo);
        }

        public void Sil(Calisma tablo)
        {
            efCaslimaRepository.Sil(tablo);
        }
    }
}
