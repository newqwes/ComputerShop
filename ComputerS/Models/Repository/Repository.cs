using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerS.Models.Repository
{
    public class Repository
    {
        //В классе Repository определено свойство по имени Computers, которое возвращает результаты чтения свойства с таким же именем в классе EFDbContext.
        
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Computer> Computers
        {
            get { return context.Computers; }
        }
    }
}