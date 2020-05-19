using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorkPattern.Entities
{
    public abstract class BaseClass
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
