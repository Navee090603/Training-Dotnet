using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    // 1️⃣ Step: Custom EventArgs class to hold data

    public class LoginEventArg : EventArgs
    {
        public string UserName { get; set; }

        public LoginEventArg(string username)
        {
            UserName = username;
        }
    }

    // 2️⃣ Step: Publisher class

    public class PublisherClass
    {
        // Event using EventHandler<T>
        public event EventHandler<LoginEventArg> eventHandler;

        public void RaiseEvent(string username,string password)
        {
            if(username=="Naveen" && password == "123")
            {
                eventHandler?.Invoke(this, new LoginEventArg(username));
            }
            else { Console.WriteLine("Invalid UserName...."); }
        }

    }        

    // 3️⃣ Step: Subscriber class

    public class SubscriberClass
    {
        public void HandleEvent(object sender, LoginEventArg e)
        {
            Console.WriteLine($"Welcome, {e.UserName}");
        }
    }
   

    // 4️⃣ Step: Program Entry
 
    class Program
    {
        public static void Main()
        {
            PublisherClass publisherClass = new PublisherClass();
            SubscriberClass subscriberClass = new SubscriberClass();

            publisherClass.eventHandler += subscriberClass.HandleEvent;

            Console.Write("Enter UserName : ");
            string name = Console.ReadLine();

            Console.Write("Enter Password : ");
            string pass = Console.ReadLine();

            publisherClass.RaiseEvent(name,pass);

            Console.ReadLine();
        }
    }
}