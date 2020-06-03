using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorkPattern.Entities
{
    public class Urun : BaseClass
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int KategoriId { get; set; }
        public decimal BirimFiyat { get; set; }
        // Relations
        public virtual Kategori Kategori { get; set; }
    }
}
