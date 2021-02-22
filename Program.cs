using System;
using System.Collections;
namespace MovieLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieMenu menu = new MovieMenu();
        }
        //!!NOTE!! I wasn't sure how to incorperate a unit test with the way I wrote my code, so I just made a usless example to demostrate that I know how to use them.
        public static int unitTest(int test){
            return test * 5;
        }
    }
}
