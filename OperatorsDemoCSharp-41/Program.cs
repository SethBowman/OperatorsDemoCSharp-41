namespace OperatorsDemoCSharp_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opeartors
            //Assignment operator

            //int x = 5;
            //int y = 10;

            //Arithmetic operators

            //int addition = x + y;
            //int subtraction = x - y;
            //int multiplicaton = x * y;
            //int division = x / y;
            //int mod = x % y; //remainder after divison

            //bool isEven = x % y == 0;
            //Console.WriteLine(isEven);

            //Unary operators

            int x = 3;
            int y = ++x; //pre increment
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine();


            int a = 3;
            int b = a++; //post increment
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();

            int c = 5;
            Console.WriteLine(--c); //pre decrement
            int d = 4;
            Console.WriteLine(d--); // post decrement
            Console.WriteLine(d);
            Console.WriteLine();


            //Relational operators

            int e = 5;
            int f = 3;

            bool isEqual = e == f;
            bool notEqual = e != f; // (!= not equal)
            bool greaterThan = e > f;
            bool lessThan = e < f;
            bool greaterThanOrEqaul = e <= f;
            bool lessThanOrEqual = e <= f;

            //Logical operators
            bool result1 = a == 5 && b > 5; // && AND
            bool result2 = b > 10 || c > 20; // || OR

            //Null coalesting operator

            int? possiblyNullValue = null;
            int notNullNumber = possiblyNullValue ?? 500;
            Console.WriteLine(notNullNumber);



        }
    }
}