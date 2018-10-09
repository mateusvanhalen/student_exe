namespace StudentExercises
    {
   public class Instructor
   {
            public string FirstName {get; set;}
            public string LastName {get; set;}
            public string SlackHandle {get; set;}
            public int Cohort {get; set;}
            //assign mentod
            public void AssignExercise (Exercise exercise, Student student){
                student.Exercises.Add(exercise);
        }
    }
}