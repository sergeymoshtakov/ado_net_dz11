using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Data.Entity
{
    public class Manager
    {
        public Guid Id { get; set; }
        public String Surname { get; set; } = null!;
        public String Name { get; set; } = null!;
        public String Secname { get; set; } = null!;
        public String Login { get; set; } = null!;
        public String PassSalt { get; set; } = null!; // rfc2898
        public String PassDk { get; set; } = null!; // rfc2898
        public Guid IdMainDep { get; set; } // osnovnoe
        public Guid? IdSecDep { get; set; } // za sumisnyztvom
        public Guid? IdChief { get; set; } // kerivnyk
        public DateTime CreateDt { get; set; }
        public DateTime? DeleteDt { get; set; }
        public String Email { get; set; } = null!;
        public String? Avatar { get; set; } // posilka na avatar

        // Navigation properties

        public Department MainDep { get; set; } // дозволяє спростити одерження окремих данних

        public Department? SecDep { get; set; }

        public Manager? Chef { get; set; }

        public IEnumerable<Manager> Workers { get; set; }
    }
}
