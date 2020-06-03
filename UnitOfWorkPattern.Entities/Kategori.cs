using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorkPattern.Entities
{
    public class Kategori : BaseClass
    {
        public Kategori()
        {
            this.Urunler = new List<Urun>();
        }
        public int Id { get; set; }
        public string Adi { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; }
    }
}
