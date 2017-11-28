using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetApplication.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string UserID;
        [StringLength(50, ErrorMessage = "Nazwa użytkownika nie może być większa niż 50 znaków.")]
        public String Username { get; protected set; }
        public String Email { get; protected set; }
        public String Password { get; protected set; }
        public int Age { get; set; }
    }
}
