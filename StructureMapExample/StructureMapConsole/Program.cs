using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using StructureMap.Attributes;

namespace StructureMapConsole
{
    class Program
    {
        //[SetterProperty]
        //public static IBusinessOne BusinessOne { get; set; }
        static void Main(string[] args)
        {
            var container = IoC();            
            IBusinessOne businessOne = container.GetInstance<IBusinessOne>();
            Console.WriteLine(businessOne.GetMessage());

            var businessTwo = container.GetInstance<BusinesssTwo>();
            Console.WriteLine(businessTwo.GetMessage());
            Console.Read();
        }
        public static IContainer IoC()
        {
            return Container.For<StructureMapRegistry>();
        }
    }
   
}
