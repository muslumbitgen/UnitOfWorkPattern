using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorkPattern.Entities
{
    public class Kategori : BaseClass
    {
        public Kategori()
        {
            this.Uruns = new List<Urun>();
        }
        public int Id { get; set; }
        public string KategoriName { get; set; }

        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
