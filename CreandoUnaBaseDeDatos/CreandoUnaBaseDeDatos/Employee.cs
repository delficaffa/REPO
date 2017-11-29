using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreandoUnaBaseDeDatos
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength (20)]
        public string Name { get; set; }

        [Required]
        [StringLength(40)]
        public string Surname { get; set; }

        public int Age { get; set; }

        [Required]
        [StringLength(60)]
        public string Position { get; set; }

        public virtual City City {get; set;}
        

        public virtual Employee Supervisor { get; set; }

        public int? SupervisorId { get; set; }

        public int Salary { get; set; }
    }
}
