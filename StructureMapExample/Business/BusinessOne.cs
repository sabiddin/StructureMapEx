using DataAccess;
using StructureMap.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IBusinessOne {
        string GetMessage();
    }
    public class BusinessOne : IBusinessOne
    {
        private readonly IDataAccessOne _dataAccessOne;
        [SetterProperty]
        public IDataAccessTwo DataAccessTwo { get; set; }
        public BusinessOne(IDataAccessOne dataAccessOne)
        {
            _dataAccessOne = dataAccessOne;
        }
        public string GetMessage()
        {
            string message = _dataAccessOne.GetMessage();
            return message += DataAccessTwo.GetMessage();
        }
       
    }
}
