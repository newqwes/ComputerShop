using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; 

namespace ComputerS.Models.Repository
{
    public class EFDbContext : DbContext //Чтобы ассоциировать класс Computer с базой данных, понадобится создать класс, производный от System.Data.Entity.DbContext и имеющий свойство для каждой таблицы базы данных, с которой планируется работать.
    {
        public DbSet<Computer> Computers { get; set; }
    }
}