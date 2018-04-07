using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDataAccessOne
    {
        string GetMessage();
    }
    public class DataAccessOne:IDataAccessOne {
        public string GetMessage()
        {
            return "Hello from Data Access One.";
        }        
    }
}
