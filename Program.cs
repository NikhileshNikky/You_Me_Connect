using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace You_Me_Connect
{
    public class Program
    {



        static void Main(string[] args)
        {
            
            Client c1 = new Client();
            Client c2 = new Client();
            ChatOperation r = new ChatOperation();
           remove r1  = new remove();


            Server s2 = new Server();
            Console.WriteLine("press 1 to Register/Unregister");
            Console.WriteLine("press 2 for Messaging Options");
            Console.WriteLine("press 3 to Send Message");
            Console.WriteLine("Press 4 to view contact list");
            Console.WriteLine("Press 5 to Add members to contact list");

            int num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1:
                    s2.Register();
                    break;
                case 2:
                    r.messageoptions();
                    break;
                case 3:
                    r.MessageReceived();
                    break;
                case 4:
                    r1.removing();
                    break;
                case 5:
                    s2.Cnt_list();
                    
                    break;


            }
            
            
            
            
            
           
            
            
            Console.ReadLine();

            
        }

    }
}
