using System;
namespace DebugWithCompiler {


    class Person {
        private string firstname;
        private string lastname;
        private char gender;

        public Person(string firstname, string lastname, char gender) {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
        }

        public string Greet() {
            if ((this.gender == 'm') || (this.gender == 'M')) {
                return "Mr " + this.firstname + " " + this.lastname;
            } else {
                return "Ms " + this.firstname + " " + this.lastname;
            }
        }
        public string FirstName() {
            return this.firstname;
        }

        public string LastName() {
            return this.lastname;
        }

    }
    class Program  {
        static void Main(string[] args) {
            Person p1 = new Person("Celine", "Dion", 'f');
            Console.WriteLine($"Dear {p1.Greet()}");            
        }

    }
}
