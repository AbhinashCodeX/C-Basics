//Console.WriteLine("Hello, World!");

using System;
using System.Threading.Channels;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "John ";
            //string lastName = "Doe";
            //string name = firstName + lastName;
            //Console.WriteLine(name);

            //String interpolation 
            //string firstName = "John";
            //string lastName = "Doe";
            //string name = $"My full name is: {firstName} {lastName}";
            //string fname = $"My full name is: {firstName}{lastName}";
            //Console.WriteLine(name);

            //Data Types in C#
            //int my_Num = 5;
            //double dob_num = 5d;
            //char my_char = 'A';
            //bool my_bool = false;
            //String my_str = "Hello World";

            //Console.WriteLine(my_Num);
            //Console.WriteLine(dob_num);
            //Console.WriteLine(my_char);
            //Console.WriteLine(my_bool);
            //Console.WriteLine(my_str);


            //Explicit Type Conversion
            //double d = 5.6;
            //int m = (int) d;
            //Console.WriteLine(m);


            //int myInt = 10;
            //double myDouble = 5.25;
            //bool myBool = true;

            //Console.WriteLine(Convert.ToString(myInt));
            //Console.WriteLine(Convert.ToString(myDouble));
            //Console.WriteLine(Convert.ToString(myBool));


            //User Input in c#
            //Console.WriteLine("Enter your username:");
            //string username = Console.ReadLine();
            //Console.WriteLine("Hello Mr." + username + " now You are a c# developer ");
            //Console.WriteLine("Enter your password:");
            //string password = Console.ReadLine();
            //Console.WriteLine("Hello Mr." + username + " now You are a c# developer and your password is:"+ password);


            //Console.WriteLine("Enter your City Name:");
            //string city = Console.ReadLine();
            //Console.WriteLine("Your live in city: " + city);

            //int x = 10;
            //x += 5;
            //x -= 5;
            //x *= 4;
            //x /= 2;
            //Console.WriteLine(x);

            //int x = 5;
            //Console.WriteLine(x > 3 && x < 10);
            //int x = 5;
            //Console.WriteLine(x>3 || x<4);
            //Console.WriteLine(Math.Max(100, 1000));
            //Console.WriteLine(Math.Min(100, 1000));
            //Console.WriteLine(Math.Sqrt(10));
            //Console.WriteLine(Math.Abs(-10));
            //Console.WriteLine(Math.Round(99.99));


            //How to find the length of the txt using txt.Length
            //string txt = "wsfbjvbjvbjkvejv";
            //Console.WriteLine("Your Txt length is :" +txt.Length);


            //Using of ToUpper() and ToLower()
            //string txt = "Abhinsh";
            //Console.WriteLine(txt.ToUpper());
            //Console.WriteLine(txt.ToLower());

            //String concatnation
            //String first = "Abhinash";
            //String last = "Panigrahi";
            //String name = String.Concat(first, last);
            //Console.WriteLine(name);

            //To Access the index of the String
            //String myString = "Abhinas";
            //Console.WriteLine(myString[3]);
            //Console.WriteLine(myString.IndexOf("a"));

            //string name = "John Doe";

            //// Location of the letter D
            //int charPos = name.IndexOf("D");

            //// Get last name
            //string lastName = name.Substring(charPos);
            //// Print the result
            //Console.WriteLine(lastName);

            // \n is used to print somthing in the next line
            // \t is used to pring somthing in the space
            // \b is used to delete somthing in the message
            //Console.WriteLine("Hello \nWorld");
            //Console.WriteLine("Hello \tWorld");
            //Console.WriteLine("Hel\blo");

            //int x = 10;
            //int y = 20;
            //Console.WriteLine(x > y);  //return false

            //int x = 10;
            //Console.WriteLine(x == 10);

            //Console.WriteLine("Enter Your Age: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("Your are Eligible to Vote Congratulations");
            //}
            //else
            //{
            //    Console.WriteLine("You are not Eligible to Vote");
            //}


            //int day = 4;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;

            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;

            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Moving Forward to Weekend");
            //        break;

            //int i = 0;
            //while (i<5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i<5);

            //for(int i=1; i <5; i++)
            //{
            //    Console.WriteLine("Hello "+i);
            //}


            //for each in C#
            //string[] cars = { "car", "bus", "truck", "auto" };
            //foreach (string i in cars) {
            //    Console.WriteLine(i);
            //}
            //}

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    if (i == 4)
            //    {
            //        break;
            //    }
            //}

            //string workout;
            //workout = "Chest Workout";
            //Console.WriteLine($"Today is monday and i am hitting {workout}");
            //workout = "Back Workout";
            //Console.WriteLine($"Today is tuesday and i am hitting {workout}");

            ////calculator by User choice
            //Console.WriteLine("choose your choice");
            //Console.WriteLine("1.Add");
            //Console.WriteLine("2.Sub");
            //Console.WriteLine("3.Mul");
            //Console.WriteLine("4.Div");
            //int c = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your First number: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your Second number: ");
            //int b = int.Parse(Console.ReadLine());

            //switch (c)
            //{
            //    case 1:

            //        Console.WriteLine("Addition is:" + (a + b));
            //        break;
            //    case 2:
            //        Console.WriteLine("Difference is: " + (a - b));
            //        break;
            //    case 3:
            //        Console.WriteLine("Product is: " + (a * b));
            //        break;
            //    case 4:
            //        if (b != 0)
            //        {
            //            Console.WriteLine("Division is: " + (a / b));
            //        }else
            //            Console.WriteLine("Cannot be divided By zero");
            //        break;

            //    default:
            //        Console.WriteLine("Please Enter a valid Choice");
            //        break;

            //Arrays
            String[] cars = {"Bus","Truck","","" };
            Console.WriteLine(cars[0]);


            }

    }

}

   
