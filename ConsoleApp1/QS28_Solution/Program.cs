/*
Q28. Create a console application where user enter his details for email id registration. 
Details to be added to a collection which holds user's details as below:
    1) User name
    2) email id
    3) password


You have to make sure that email id entered by the user should be unique while registering. If a user 
enters the email id which is already registered, throw an exception of type "DuplicateEmailldException" 
and user should get the error message "Email id already exists".

For any other kind of errors like name, password not provided, it should throw
"AccountCreationException" and error message should be displayed to user.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Two CUSTOM Exceptions are here
public class DuplicateEmailIdException : Exception
{
    public DuplicateEmailIdException(string msg) : base(msg) { }
}
public class AccountCreationException : Exception
{
    public AccountCreationException(string msg) : base(msg) { }
}
namespace QS28_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Already present in the database
            List<User> registered_users = new List<User>();
            registered_users.Add(new User { Username = "ankit.97", Password = "ankit789455###", Emailid = "ankitkanjilal.97@gmail.com" });
            registered_users.Add(new User { Username = "anand.98", Password = "789anand455###", Emailid = "anand@gmail.com" });
            registered_users.Add(new User { Username = "bikash.99", Password = "bikash#789455###", Emailid = "bikash.99@gmail.com" });
            registered_users.Add(new User { Username = "raman.01", Password = "raman@789455###", Emailid = "raman.7@gmail.com" });

            // for the new user
            Console.Write("Enter Username : ");
            string username = Console.ReadLine();
            Console.Write("Enter Email-id : ");
            string email = Console.ReadLine();
            Console.Write("Enter Password : ");
            string password = Console.ReadLine();
            try
            {
                CheckUserInfo(username, password, email, registered_users);
            }
            catch( DuplicateEmailIdException exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine(exp.StackTrace);
            }
            catch(AccountCreationException exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine(exp.StackTrace);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using this Service... :)");
            }
            Console.WriteLine();
            Console.WriteLine("Updated Database : ");
            foreach (User user in registered_users)
            {
                Console.WriteLine("Username: " + user.Username + "\t" + "Email-id: " + user.Emailid);
            }
        }

        //checking the email-id already exist or not
        static void CheckUserInfo(string username, string password, string email, List<User> registered_users)
        {
            // checking for email-id conditions....
            foreach (User usr in registered_users)
            {
                if (usr.Emailid.Equals(email))
                {
                    //Console.WriteLine("Already registered...");
                    throw new DuplicateEmailIdException("Email id already exists...");
                }
                if (username=="")
                {
                    throw new AccountCreationException("AccountCreationException... Username can't be null");
                }
                if (password.Equals(""))
                {
                    throw new AccountCreationException("AccountCreationException... Password can't be null");
                }
            }
            // otherwise
            User u = new User { Username = username, Password = password, Emailid = email };
            registered_users.Add(u);
            Console.WriteLine("Registration successful...");
        }
        // class user
        class User
        {
           public string Username { set; get; }
           public string Emailid { set; get; }
           public string Password { set; get; }
        }
        
    }
}
