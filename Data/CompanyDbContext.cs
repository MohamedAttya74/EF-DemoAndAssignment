using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DemoAndAssignment.Data
{
    internal class CompanyDbContext : DbContext                   //   Database   المسؤل عن التعامل مع ال  Class  ال 
    {

        public CompanyDbContext() :base()
        {
                                 // Object from DbContext   دي مش الطريقه الوحيده علشان اعمل 
        }                      //           دا ف اكتر من مكان   Object   هناخدها قدام ودي لو محتاح ال    Dependancy Injection     في حاجه تانيه اسمها 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer( "Server = . ; Database = Company ;Trusted_Connection = True ; ");  // ConnectionString 
        }


        public DbSet<Employee> Employees { get; set; }
    }
}



// OnConfifaring :  ConectionString    بنحدد من خلالها ال   Method  دي 