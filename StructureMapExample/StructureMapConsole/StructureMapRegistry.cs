using Business;
using DataAccess;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMapConsole
{
    public class StructureMapRegistry: Registry
    {               
        public StructureMapRegistry()
        {
            Scan(scan =>
            {
                scan.Assembly("DataAccess");
                scan.Assembly("Business");
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
            Policies.SetAllProperties(p => p.WithAnyTypeFromNamespace("DataAccess"));
            Policies.SetAllProperties(p => p.WithAnyTypeFromNamespace("DataAccess"));
          //  For<IBusinessOne>().Use<BusinessOne>();
           // For<IDataAccessOne>().Use<DataAccessOne>();
        }
    }
}
