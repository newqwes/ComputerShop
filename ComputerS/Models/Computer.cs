using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComputerS.Models
{
    public class Computer
    {
        /* В этом файле определен простой класс Computer с автоматически реализуемыми свойствами,
         которые соответствуют столбцам в созданной таблице базы данных.*/
        public int ComputerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}