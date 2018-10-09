using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort TwentySix = new Cohort() {
                Name = "26"
            };

            Cohort TwentyEight = new Cohort() {
                Name = "28"
            };
            // This way is initializing the object "Twenty Seven" with the property of name
            //this is the way we setup without a consructor.
            Cohort TwentySeven = new Cohort() {
                Name = "27"
            };

            Student Matt = new Student() {
                FirstName = "Matthew",
                LastName = "Hall",
                SlackHandle = "Mateusvanhalen",
                Cohort = TwentySeven

            };

            Student Klaus = new Student() {
                FirstName = "Klaus",
                LastName = "Hardt",
                SlackHandle = "Klaus",
                Cohort = TwentySeven,

            };

            Student Taylor = new Student() {
                FirstName = "Taylor",
                LastName = "Gulley",
                SlackHandle = "Taylor",
                Cohort = TwentySeven,

            };

            Student Mark = new Student() {
                FirstName = "Mark",
                LastName = "Hale",
                SlackHandle = "Mark",
                Cohort = TwentySeven,

            };

            Exercise Ex1 = new Exercise() {
                Name = "Ex1",
                Language = "JavaScript"
            };

            Exercise Ex2 = new Exercise() {
                Name = "Ex2",
                Language = "Python"
            };

            Exercise Ex3 = new Exercise() {
                Name = "Ex3",
                Language = "C Sharp"
            };

            Exercise Ex4 = new Exercise() {
                Name = "Ex4",
                Language = "JavaScript"
            };
            Instructor Meg = new Instructor() {
                FirstName = "Meg",
                LastName = "Ducharme",
                SlackHandle = "Meg",
                Cohort = TwentySeven
            };

            Instructor Andy = new Instructor() {
                FirstName = "Andy",
                LastName = "Collins",
                SlackHandle = "Andy",
                Cohort = TwentySeven
            };

            Instructor Steve = new Instructor() {
                FirstName = "Steve",
                LastName = "Brownlee",
                SlackHandle = "Steve",
                Cohort = TwentySeven
            };

            Instructor Kimmy = new Instructor() {
                FirstName = "Kimmy",
                LastName = "Bird",
                SlackHandle = "Kimmy",
                Cohort = TwentySeven
            };


            //Kimmy is Instructor . Method (parameters);
            Kimmy.AssignExercise(Ex1, Matt);
            Kimmy.AssignExercise(Ex2, Taylor);
            Steve.AssignExercise(Ex1, Klaus);
            Steve.AssignExercise(Ex3, Klaus);
            Meg.AssignExercise(Ex2, Taylor);


            List<Student> students = new List<Student> () {
                Mark, Taylor, Matt, Klaus,
            };

        }
    }
}
