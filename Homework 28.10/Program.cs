//Задание 1
//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            Console.WriteLine("1. Decimal to Binary");
//            Console.WriteLine("2. Binary to Decimal");
//            Console.WriteLine("3. Decimal to Hexadecimal");
//            Console.WriteLine("4. Hexadecimal to Decimal");
//            Console.Write("Choose: ");

//            int choice = int.Parse(Console.ReadLine());

//            Console.Write("Enter number: ");
//            string input = Console.ReadLine();

//            int number;
//            string result;

//            switch (choice)
//            {
//                case 1:
//                    number = int.Parse(input);
//                    result = Convert.ToString(number, 2);
//                    break;

//                case 2:
//                    number = Convert.ToInt32(input, 2);
//                    result = number.ToString();
//                    break;

//                case 3:
//                    number = int.Parse(input);
//                    result = Convert.ToString(number, 16);
//                    break;

//                case 4:
//                    number = Convert.ToInt32(input, 16);
//                    result = number.ToString();
//                    break;

//                default:
//                    throw new Exception("Wrong menu choice!");
//            }

//            Console.WriteLine("Result: " + result);
//        }
//        catch (OverflowException)
//        {
//            Console.WriteLine("Error: number is outside the int range!");
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Error: incorrect number format!");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }
//    }
//}

//Задание 2
//using System;

//class ForeignPassport
//{
//    private string number;
//    private string fullName;
//    private DateTime issueDate;
//    private DateTime expiryDate;

//    public ForeignPassport(string number, string fullName,
//        DateTime issueDate, DateTime expiryDate)
//    {
//        if (string.IsNullOrWhiteSpace(number))
//            throw new Exception("Invalid passport number!");

//        if (string.IsNullOrWhiteSpace(fullName))
//            throw new Exception("Invalid full name!");

//        if (issueDate > DateTime.Now)
//            throw new Exception("Invalid issue date!");

//        if (expiryDate <= issueDate)
//            throw new Exception("Invalid expiry date!");

//        this.number = number;
//        this.fullName = fullName;
//        this.issueDate = issueDate;
//        this.expiryDate = expiryDate;
//    }

//    public override string ToString()
//    {
//        return "Passport number: " + number +
//               "\nFull name: " + fullName +
//               "\nIssue date: " + issueDate.ToShortDateString() +
//               "\nExpiry date: " + expiryDate.ToShortDateString();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            ForeignPassport passport = new ForeignPassport(
//                "AB123456",
//                "Ivan Petrenko",
//                new DateTime(2024, 5, 10),
//                new DateTime(2034, 5, 10)
//            );

//            Console.WriteLine(passport);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }
//    }
//}
