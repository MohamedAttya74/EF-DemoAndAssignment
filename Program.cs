using EF_DemoAndAssignment.Data;

namespace EF_DemoAndAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyDbContext context = new CompanyDbContext();

            var employee = context.Employees.Where(E => E.ID==1).FirstOrDefault();

            /// using CompanyDbContext context = new CompanyDbContext() ;   // Update for the Using 
            /// Code 

            /// using (CompanyDbContext context = new CompanyDbContext())
            /// {         // Sentacx Sugar  With Out the Try,finaly 
            ///
            ///              //code 
            /// } ;

            /// CompanyDbContext context = new CompanyDbContext();
            /// 

            ///   try
            ///   {
            ///        // Code
            ///   }
            ///   finally
            ///   {
            ///       //Close the Connection
            ///       context.Dispose();
            ///
            ///   }








        }
    }
}

// Notes 
/*
 
Database احنا بنعمل كدا علشان الابليكيشن يتواصل مع ال     
عن طريق ال 
1- ADO.NET :   ودا القديم 
2- ORM :    ودا الجديد والي الكل بيستخدمه دلوقتي 

ORM : Object Relatioanl Mapping 
ORM:   Concept  موجود بشكل عامل فكل اجزاء الباك اند  
ودا زي ال  
1- Entitiy FrameWork Core 9.0   :   الي ممكن تحتالجها  Features    ديناصور بمعني انو فيه كل ال 
2- Dapper 
 
 Entitiy FrameWork Core :


 1-   Mapping   :
      التاني   side هيشتغل ف ال   ORM     وال side  لا انا هشتغل ف   Two side   هو ان انا مش هشتغل فال  Mappingوفكره ال 
 
 => From Code (Classes) --> Generate Database (Tables)  ==> Code First 

 => From Database (Tables) -->  Generate Code (Classes) ==> DataBase Frist
                   هو الوحيد الي شغال كدا    Entitiy FrameWork Core   واحد غير ال  Side  بيشتغلوا ف    ORMS   مش كل ال 
 
 Code First ::  هو الاكثر استخداما لسببين 
 1-  DataBase Frist  اسهل من ان انا اشتغل 
 2- وهفضل رايح جاي بين البرامج لا هو سهل عليا الدنيا وهي اني اشتغل ف مكان واحد  SQL  وهي انو هو بيخليني اشتغل ف مكان واحد مش هفتح ال  
 
 DataBase Frist :: قديمه ف دا مش هيخليني ابني اي حاجه من الاول تاني  Database  عندها Company  هتبقي احسن ف حاله واحده وهي ان ال 
 
 
 
 
 
 2- L2EF => (LINQ TO Entity FrameWork)   
              بتاعي  Programe  جوه ال   SQL   ينفع اكتب 
 
                     والخطوه دي بنسمهيا 
     ==> Query Object Model 
                                     وتعالي نفسر كل حاجه ف الجمله دي 
 
    Model :  Tables   ف احدي ال   Data  الي بيمثل شكل ال  Class  دا ال 
   Object Model :     Table او ال  Model  داخل ال   Row   ودا بيمثل ال 
   Query Object Model :   Crude   والجزء دا كله اسمه ال 



    Dapper  ==>            Mapping  ومفهوش    Query Object Model  دا معمله علشات ال 
                             Row SQL            وبنكتب 




              ORM    و بعد ما طلعلنا ال  ORM  بتقارن بين ما قبل ال  Artical      عندنا     
                                 ADO.NET  بيستخدم ال   ORM    بس بشكل غير مبارشر لان ال  ADO.NET يعتبر بنستخد ال   ORM  وحتي لما طلع ال     ADO.NET     كان عندنا حاجه اسمها ORM قبل ال 

        ADO.NET :  Low Level code 
            يبقي شوفهم لانهم مهمين جدا جدا  Dapper    وال  EF Core   وال  ADO.NET  في مقارن كبيره بين ال 
            

 */
