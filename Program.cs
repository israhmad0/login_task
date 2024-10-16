using System;

class Program
{
    static void Main()
    {

        string USER = "israa";
        string PASSWORD = "102024";

        Console.WriteLine("Welcome to the Simple Login System!");

        Console.WriteLine("Enter your Username:");
        string user = Console.ReadLine();

        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();
      
        if (string.IsNullOrEmpty(user)) {
            Console.WriteLine("Username cannot be empty.");
        }
      else if (string.IsNullOrEmpty(password)) {
        Console.WriteLine("Password cannot be empty.");
        }

        if (USER != user || PASSWORD !=password) {
            Console.WriteLine("Invalid username or password. Access denied.");
        }

        else
        {
            Random random = new Random();
            int otp = random.Next(100000, 999999);
            Console.WriteLine("OTP:" + otp);
            Console.WriteLine("Enter The 6 Digit OTP:");
            int user_otp = Convert.ToInt32(Console.ReadLine());
            if (user_otp == otp)
            {
                Console.WriteLine("Success! You are logged in.");
            }
            else {
                Console.WriteLine("Invalid OTP. Access denied.");
               
            }

        }
    }
}