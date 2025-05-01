namespace Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hexadecimal - denary conversion
            //define array of hexadecimal values
            string[] hexvals = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

            //convert two random denary numbers to hexadecimal (use the index values of hexadecimal values array)
            Random rnd = new Random();
            int num1 = rnd.Next(0, 16);
            int num2 = rnd.Next(0, 16);

            Console.WriteLine("Random");
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            string n1 = hexvals[num1];
            string n2 = hexvals[num2];

            //convert hexadecimal number to denary 
            int den = (num1 * 16) + num2;

            //output hexadecimal and denary numbers
            Console.WriteLine("Hexadecimal");
            Console.WriteLine(n1 + n2);
            Console.WriteLine("Decimal");
            Console.WriteLine(den);
        }
    }
}
