using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsGrade
{
class Program
    {
        static void Main(string[] args)
        {
            //initialize variables -graded exam
            int finalExamination = 5;

            int Martha1 = 93;
            int Martha2 = 87;
            int Martha3 = 98;
            int Martha4 = 95;
            int Martha5 = 100;

            int James1 = 80;
            int James2 = 83;
            int James3 = 82;
            int James4 = 88;
            int James5 = 85;

            int Bella1 = 84;
            int Bella2 = 96;
            int Bella3 = 73;
            int Bella4 = 85;
            int Bella5 = 79;


            int Jack1 = 90;
            int Jack2 = 92;
            int Jack3 = 98;
            int Jack4 = 100;
            int Jack5 = 97;

            int MarthaSum = Martha1 + Martha2 + Martha3 + Martha4 + Martha5;
            int JameSum   = James1 + James2 + James3 + James4 + James5;
            int BellaSum  = Bella1 + Bella2 + Bella3 + Bella4 + Bella5;
            int JackSum   = Jack1 + Jack2 + Jack3 + Jack4 + Jack5;


            Console.WriteLine("Martha: "  + MarthaSum);
            Console.WriteLine("James: "  + JameSum);
            Console.WriteLine("BellaSum: "  + BellaSum);
            Console.WriteLine("JackSum: "  + JackSum);
            


        }
    }
}