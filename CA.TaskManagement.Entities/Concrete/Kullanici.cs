using CA.TaskManagement.Entities.Interfaces;
using System.Collections.Generic;

namespace CA.TaskManagement.Entities.Concrete
{
    public class Kullanici : ITable
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public List<Calisma> Calismalar { get; set; }
    }
}
