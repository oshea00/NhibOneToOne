using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibOneToOne
{
    public class Boxer
    {
        public virtual int Id { get; protected set; }
        public virtual string WeightClass { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
