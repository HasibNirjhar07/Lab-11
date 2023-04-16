using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    public class Executive
    {
        public Manager Manager { get; set; }
        public decimal BonusPercentage { get; set; }

        public Executive(Manager manager, decimal bonusPercentage)
        {
            Manager = manager;
            BonusPercentage = bonusPercentage;
        }

        public static explicit operator Executive(Employee v)
        {
            throw new NotImplementedException();
        }
    }
}
