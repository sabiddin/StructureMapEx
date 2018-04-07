using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IDataAccessTwo
    {
        string GetMessage();
    }
    public class DataAccessTwo : IDataAccessTwo
    {
        public string GetMessage()
        {
            return "Hello from Data Access Two";
        }
    }
}
