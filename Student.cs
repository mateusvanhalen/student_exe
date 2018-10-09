using System.Collections.Generic;

namespace StudentExercises
    {
   public class Student
   {
       public string FirstName {get; set;}
       public string LastName {get; set;}
       public string SlackHandle {get; set;}

       public string FullName {
           get {
               return $"{FirstName} {LastName}";
           }
       }

        // this naming is because we are naming our own type. IT IS A SINGLE INSTANCE that will hold many strings
       public Cohort Cohort {get; set;}
       public List<Exercise> Exercise = new List<Exercise>();
   }

}