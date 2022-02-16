using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace You_Me_Connect
{
    public class Client
    {
        #region Registration Method
        public void registration()
        {
            string name = Console.ReadLine();
            long ph = long.Parse(Console.ReadLine());
        }
        #endregion

        #region Messaging
        public void SendMessage()
        {
            Console.WriteLine("Type here....");
           string msg= Console.ReadLine();
            Console.WriteLine("Message stored in server");
        }
        #endregion
    }

    public class contact_list
    {

        List<string> chi = new List<string>();
        string a = "Nikhil";
        string b = "sreyesh";
        string c = "lohit";
        string d = "lakki";

        #region Removing Participants Methods
        public void list()
        {
            chi.Add(a);
            chi.Add(b);
            chi.Add(c);
            chi.Add(d);
            foreach (string st in chi)
            {
                Console.WriteLine(st);
            }



        }
        public void RemoveParticipant_Nikhil()
        {
            chi.Remove(a);
            foreach (string st in chi)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();

        }
        public void RemoveParticipant_sreyesh()
        {
            chi.Remove(b);

            foreach (string st in chi)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();

        }
        public void RemoveParticipant_lohit()
        {
            chi.Remove(c);
            foreach (string st in chi)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();

        }
        public void RemoveParticipant_lakki()
        {
            chi.Remove(d);
            foreach (string st in chi)
            {
                Console.WriteLine(st);
            }
            Console.ReadLine();

        }
        
    }

    public class remove
    {
        public void removing()
        {


            contact_list l = new contact_list();
            l.list();
            Console.WriteLine("Enter a to remove Nikhil");
            Console.WriteLine("Enter b to remove sreyesh");
            Console.WriteLine("Enter c to remove lohit");
            Console.WriteLine("Enter d to remove lakki");
            char input = char.Parse(Console.ReadLine());
            string s = input.ToString().ToLower();
            switch (s)
            {
                case "a":
                    l.RemoveParticipant_Nikhil();
                    break;
                case "b":
                    l.RemoveParticipant_sreyesh();
                    break;
                case "c":
                    l.RemoveParticipant_lohit();
                    break;
                case "d":
                    l.RemoveParticipant_lakki();
                    break;
            }
            Console.WriteLine("contact List after removing participant");
            l.list();
        }
    }

    #endregion

}










public class Options
    {

    #region Options methods
    public void Mute()
        {
            Console.WriteLine("This chat is temporarily muted for 8 hrs..");

        Console.Read();


        }
        public void view()
        {
            Console.WriteLine("I think you are trying to view this msg..Wait a sec and try other options too.");
            Console.Read();
            
        }
        public void block()
        {
        Console.WriteLine("You will no longer receive msgs from this contact.. ");

            
        }
        public void deleteChat()
        {
        Console.WriteLine("Are you sure to delete this contact?");
        Console.WriteLine("Type 'yes' to delete");
        
        string ch = Console.ReadLine();
        if(ch=="yes")
        {
            Console.WriteLine("Deleting Chat");
        }

        }
    #endregion

}



