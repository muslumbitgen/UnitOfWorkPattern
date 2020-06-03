using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorkPattern.Entities
{
    public abstract class BaseClass
    {
        public DateTime OlusturmaTarihi { get; set; } = DateTime.Now;
    }
}
