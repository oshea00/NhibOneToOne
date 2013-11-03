using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace NhibOneToOne
{
    class BoxerMap : ClassMap<Boxer>
    {
        public BoxerMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.WeightClass);
            // The convention assumes _Id - use column to specify explicitly.
            References(x => x.Employee).Column("EmployeeId").Unique();
        }
    }
}
