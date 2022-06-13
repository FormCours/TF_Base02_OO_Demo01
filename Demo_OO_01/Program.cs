using Demo_OO_01.Models;
using System;

namespace Demo_OO_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student zaza = new Student();
            zaza.Firstname = "Zaza";
            zaza.Lastname = "Vanderquack";
            zaza.Result = 19;


            Student della = new Student();
            della.Firstname = "Della";
            della.Lastname = "Duck";
            della.Result = 22;
        }
    }


}
