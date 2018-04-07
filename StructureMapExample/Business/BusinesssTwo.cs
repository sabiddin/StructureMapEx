using DataAccess;
using StructureMap.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   
    public class BusinesssTwo
    {
        [SetterProperty]
        public IDataAccessTwo DataAccessTwo { get; set; }

        public string GetMessage() {
            return DataAccessTwo.GetMessage();
        }
    }
}
