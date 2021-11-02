using System;

namespace Movie {
    class Program {
        static void Main(string[] args) {

            var shrek =
                new Movie("Shrek", "Comedy", "PG", 2001, 90, "Jenson/Andrew");

            var blackpanther =
                new Movie("Black Panther", "Action", "PG-13", 2018, 135, "Coogler");

            var thelastunicorn =
                new Movie("The Last Unicorn", "Fantasy", "PG", 1982, 92, "Rankin/Bass");

            var thepincessbride =
                new Movie("The Princess Bride", "Fantasy", "PG", 1987, 98, "Reiner");

            var abugslife =
                new Movie("A Bug's Life", "Family", "G", 1998, 95, "Lasseter, Stanton");

            Console.WriteLine(shrek.Print());
            Console.WriteLine(blackpanther.Print());
            Console.WriteLine(thelastunicorn.Print());
            Console.WriteLine(thepincessbride.Print());
            Console.WriteLine(abugslife.Print());
            
        }
    }
}
