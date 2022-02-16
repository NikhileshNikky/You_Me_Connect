using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace You_Me_Connect
{
    public class Server
    {
        Dictionary<string, long> ctlist1 = new Dictionary<string, long>();
        List<string> grpmem = new List<string>();

        public char r;


        #region Server_Methods
        public void Register()
        {
            Console.WriteLine("Type 'r' to Register");
            Console.WriteLine("Type 'u' to Unregister");
            char ch = char.Parse(Console.ReadLine());
            string r = ch.ToString().ToLower();
            switch (r)
            {
                case "r":
                    Console.WriteLine("Enter your Name and Phone number");
                    Fill_details();
                    break;
                case "u":
                    Unregister();
                    break;




            }


        }
        public void Fill_details()
        {
            Client c1 = new Client();
            c1.registration();
            Console.WriteLine("Registration Successful..");
            Console.WriteLine("Enjoy the experience of You_Me_Connect..");
            Console.Read();

        }
        public void Unregister()
        {

        }
        public void Cnt_list()
        {
            int i = 1;
            Console.WriteLine("enter the how many number of contacts you need to add: ");
            int n1 = Convert.ToInt32(Console.ReadLine());


            while (i <= n1)
            {
                Console.WriteLine("enter the {0} name of the contact: ", i);
                string name = Console.ReadLine();
                Console.WriteLine("enter the {0} number of the contact: ", i);
                long number = long.Parse(Console.ReadLine());
                ctlist1.Add(name, number);
                i++;
            }
            Console.WriteLine("*****Contact list***** ");
            foreach (KeyValuePair<string, long> d in ctlist1)
            {
                Console.WriteLine(d);
            }
            FileInfo fn = new FileInfo(@"F:\PhoneBook.txt");
            if (fn.Exists)
            {


                using (StreamWriter swr = fn.AppendText())
                {
                    swr.WriteLine("*****Contact list***** ");

                    foreach (KeyValuePair<string, long> d in ctlist1)
                    {
                        swr.WriteLine(d);
                    }
                }
            }
                
        }
        public void addmemgrp()
        {
            int i = 1;
            Console.WriteLine("enter the how many number of contacts you need to add to the group: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            while (i <= n1)
            {
                Console.WriteLine("enter the name of {0} member: ", i);
                string name = Console.ReadLine();
                if (!ctlist1.ContainsKey(name))
                {
                    Console.WriteLine("The {0} name is not register please register", i);
                    Cnt_list();
                }
                else
                {
                    grpmem.Add(name);


                }
                i++;

            }
            Console.WriteLine(" displaying all the group members you wareadded");
            foreach (string name in grpmem)
            {
                Console.WriteLine(name);
            }
            Console.Read();




        }
        public void remvmem()
        {
            Cnt_list();
            addmemgrp();
            Console.WriteLine("if you want to remove a member press\"1\" else press any ket to continue");
            string num1 = (Console.ReadLine());

            if (num1 == "1")
            {
                Console.WriteLine("enter the name ");
                string name_r = Console.ReadLine();
                grpmem.Remove(name_r);
                foreach (string n in grpmem)
                {
                    Console.WriteLine(n);
                }
                Console.Read();
            }


        }
        public static void file()
        {
            FileInfo fn = new FileInfo(@"F:\TestReadWrite.txt");
            if (fn.Exists)
            {


                using (StreamWriter swr = fn.AppendText())
                {
                    swr.WriteLine("*****Contact list***** ");
                  //  foreach (KeyValuePair<string, long> d in ctlist1)
                    {
                      //  Console.WriteLine(d);
                    }
                }
                /*string path = @"F:\Testing.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter s = File.CreateText(path))
                    {
                        s.Write()
                    }
                }*/
            }


        }
    }
    #endregion 
    
    public class users_list
    {
        Dictionary<string, long> cl = new Dictionary<string, long>();
        public void list()
        {
             

        }
    }
    public class ChatOperation
    {

        #region Messaging Methods

        public void MessageReceived()
        {
            Client ms = new Client();
            ms.SendMessage();
        }
        public void messageoptions()
        {
            Options o = new Options();
            Console.WriteLine("Enter 1 to mute chat");
            Console.WriteLine("Enter 2 to view");
            Console.WriteLine("Enter 3 to block");
            Console.WriteLine("Enter 4 to deleteChat");
            
            int p = int.Parse(Console.ReadLine());
            switch (p)
            {
                case 1:
                    o.Mute();
                    break;
                case 2:
                    o.view();
                    break;
                case 3:
                    o.block();
                    break;
                case 4:
                    o.deleteChat();
                    break;
            }
           

        }

    }

    #endregion
}
