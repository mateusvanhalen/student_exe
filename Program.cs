using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Matt = new Student() {
                FirstName = "Matthew",
                LastName = "Hall",
                SlackHandle = "Mateusvanhalen",
                Cohort = "27",
                CurrentExercise =
            };
=
            Student Klaus = new Student() {
                FirstName = "Klaus",
                LastName = "Hardt",
                SlackHandle = "Klaus",
                Cohort = "27",
                CurrentExercise =
            };

            Student Taylor = new Student() {
                FirstName = "Taylor",
                LastName = "Gulley",
                SlackHandle = "Taylor",
                Cohort = "27",
                CurrentExercise =
            };

            Student Mark = new Student() {
                FirstName = "Mark",
                LastName = "Hale",
                SlackHandle = "Mark",
                Cohort = "27",
                CurrentExercise =
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
                Cohort = "27"
            };

            Instructor Andy = new Instructor() {
                FirstName = "Andy",
                LastName = "Collins",
                SlackHandle = "Andy",
                Cohort = "27"
            };

            Instructor Steve = new Instructor() {
                FirstName = "Steve",
                LastName = "Brownlee",
                SlackHandle = "Steve",
                Cohort = "27"
            };

            Instructor Kimmy = new Instructor() {
                FirstName = "Kimmy",
                LastName = "Bird",
                SlackHandle = "Kimmy",
                Cohort = "27"
            };

            Cohort 27 = new Cohort() {
                Name = "27",
                Student = "List",
                Instructor = "Steve",
            };

            Cohort 26 = new Cohort() {
                Name = "26",
                Student = "List",
                Instructor = "Steve",
            };

            Cohort 28 = new Cohort() {
                Name = "28",
                Student = "List",
                Instructor = "Brenda",
            };

            List<Student> students = new List<Student> () {
                Mark, Taylor, Matt, Klaus,
            };
