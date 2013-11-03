using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace NhibOneToOne
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.FirstName);
            Map(x => x.LastName);
            HasOne(x => x.Boxer).Cascade.All();
        }
    }
}
