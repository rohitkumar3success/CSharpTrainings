using System;

namespace Eventmgr
{
    using System;

    namespace Eventmgr
    {
        class Eventmngr // PARENT CLASS
        {
            public string nameofevent; //name of event
            public string typeofevent; // type of event
            public string scheduleofevent; //date of event

            public int guestlist; //no of person to be invited

            public int packageoffer; // offer to be integrated

            public int totalexpenditure; // total expense
            public string venue; // place for event


            public void setnameofevent(string noe)
            {
                nameofevent = noe;
            }

            public void settypeofevent(string toe)
            {
                typeofevent = toe;
            }

            public void setguestlist(int gl)
            {
                guestlist = gl;
            }

            public void setpackageoffer(int po)
            {
                packageoffer = po;
            }
            public void setscheduleofevent(string sod)
            {
                scheduleofevent = sod;
            }

            public int gettotalexpenditure()// expense calcualting for no of guests
            {
                if (packageoffer == 1)
                {
                    totalexpenditure = 500 * guestlist + 20000;
                    return totalexpenditure;
                }

                else if (packageoffer == 2)
                {
                    totalexpenditure = 300 * guestlist + 10000;
                    return totalexpenditure;
                }

                else if (packageoffer == 3)
                {
                    totalexpenditure = 150 * guestlist + 5000;
                    return totalexpenditure;
                }

                else
                {
                    totalexpenditure = 0;
                    return totalexpenditure;
                }
            }

            public void setVenue(string ven) //venue variable
            {
                venue = ven;
            }

        }
    }


    namespace Eventmgr //for Birhday event
    {

        class Birthday : Eventmngr // Child Class
        {
            public string music;
            public void setMusicType(string mt)
            {
                music = mt;
            }
        }
    }


    namespace Eventmgr
    {

        class Marriage : Eventmngr // Child Class
        {
        }
    }

    namespace Eventmgr
    {

        class Farewell : Eventmngr // Child Class
        {
        }
    }

    namespace Eventmgr// initialisation of program 
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("@@EVENT __MANAGEMENT __SYSTEM@@");
                Console.WriteLine("Press 9 if you want to organize an event");
                int ans = Convert.ToInt32(Console.ReadLine());
                if (ans == 5)
                {
                    goto label;

                }
                else
                {
                    Console.WriteLine("Exit");
                }
            label:
                Console.WriteLine("Select the event ");
                Console.WriteLine("Enter 1 for a Birthday Event.");
                Console.WriteLine("Enter 2 for a Marriage Event.");
                Console.WriteLine("Enter 3 for a Engagement Event.");
                Console.WriteLine("Enter your event opt: ");
                int opt = Convert.ToInt32(Console.ReadLine());

                if (opt == 1)
                {
                    Birthday obj1 = new Birthday();
                    Console.WriteLine("Enter the name of event: ");
                    string name = Console.ReadLine();
                    obj1.setnameofevent(name);

                    Console.WriteLine("\n");
                    Console.WriteLine("Enter the type of the event: ");
                    string ptype = Console.ReadLine();
                    obj1.settypeofevent(ptype);

                    Console.WriteLine("\n");
                    Console.WriteLine("Enter the Schedule of the event: ");
                    string dtype = Console.ReadLine();
                    obj1.setscheduleofevent(dtype);

                    Console.WriteLine("\n");
                    Console.WriteLine("Enter the type of music : ");
                    string sttype = Console.ReadLine();
                    obj1.setMusicType(sttype);



                    Console.WriteLine("\n");
                    Console.WriteLine("Enter the no of persons: ");
                    int guestlist = Convert.ToInt32(Console.ReadLine());
                    obj1.setguestlist(guestlist);

                    Console.WriteLine("\n");
                    Console.WriteLine("Select the packageoffer you want for the event");
                    Console.WriteLine("Press 1 for Platinum packageoffer");
                    Console.WriteLine("Press 2 for Gold packageoffer");
                    Console.WriteLine("Press 3 for Silver packageoffer");
                    Console.WriteLine("Enter your choice: ");
                    int packageoffer = Convert.ToInt32(Console.ReadLine());
                    obj1.setpackageoffer(packageoffer);


                    Console.WriteLine("\n");
                    Console.WriteLine("enter your desired venue: ");
                    string ven = Console.ReadLine();
                    obj1.setVenue(ven);

                    int expenditure = obj1.gettotalexpenditure();

                    Console.WriteLine("Event planned Details:\n");
                    Console.WriteLine("event Name:" + obj1.nameofevent);
                    Console.WriteLine("Event Type: " + obj1.typeofevent);
                    Console.WriteLine("Time: " + obj1.scheduleofevent);
                    Console.WriteLine("Music Type: " + obj1.music);
                    Console.WriteLine("Number of guests: " + obj1.guestlist);
                    Console.WriteLine("packageoffer Selected : " + obj1.packageoffer);
                    Console.WriteLine("Venue: " + obj1.venue);

                    Console.WriteLine("totalexpenditure: " + obj1.totalexpenditure);
                }

                else if (opt == 2)
                {
                    Marriage obj1 = new Marriage();
                    Console.WriteLine("Enter the name of event: ");
                    string name = Console.ReadLine();
                    obj1.setnameofevent(name);

                    Console.WriteLine("\n");
                    Console.WriteLine("Enter the type of the party: ");
                    string ptype = Console.ReadLine();
                    obj1.settypeofevent(ptype);

                    Console.WriteLine("\n");
                    Console.WriteLine("Enter the Date of the event: ");
                    string dtype = Console.ReadLine();
                    obj1.setscheduleofevent(dtype);

                    Console.WriteLine("\n");
                    Console.WriteLine("Enter the number of guests: "); // Getting estimated number of Guests.
                    int nguest = Convert.ToInt32(Console.ReadLine());
                    obj1.setguestlist(nguest);

                    Console.WriteLine("\n");
                    Console.WriteLine("Choose one of the following packageoffers: ");
                    Console.WriteLine("Press 1 for Platinum packageoffer");
                    Console.WriteLine("Press 2 for Gold packageoffer");
                    Console.WriteLine("Press 3 for Silver packageoffer");
                    Console.WriteLine("Enter your choice: ");
                    int packageoffer = Convert.ToInt32(Console.ReadLine());
                    obj1.setpackageoffer(packageoffer);


                    Console.WriteLine("\n");
                    Console.WriteLine("enter your place: ");
                    string ven = Console.ReadLine();
                    obj1.setVenue(ven);



                    int expenditure = obj1.gettotalexpenditure();


                    Console.WriteLine("Here's the details of the event you are planning for:\n");
                    Console.WriteLine("Event Name:" + obj1.nameofevent);
                    Console.WriteLine("Event  Type: " + obj1.typeofevent);
                    Console.WriteLine("Event Time: " + obj1.scheduleofevent);
                    Console.WriteLine("Guest list: " + obj1.guestlist);
                    Console.WriteLine("packageoffer Selected : " + obj1.packageoffer);
                    Console.WriteLine("Venue: " + obj1.venue);


                    Console.WriteLine("totalexpenditure: " + obj1.totalexpenditure);

                }

                else if (opt == 3)
                {
                    Farewell obj1 = new Farewell();
                    Console.WriteLine("Enter the name of event: ");
                    string name = Console.ReadLine();
                    obj1.setnameofevent(name);

                    Console.WriteLine("\n");
                    Console.WriteLine("Enter the type of the party: ");
                    string ptype = Console.ReadLine();
                    obj1.settypeofevent(ptype);

                    Console.WriteLine("\n");
                    Console.WriteLine("Enter the Date of the event: ");
                    string dtype = Console.ReadLine();
                    obj1.setscheduleofevent(dtype);


                    Console.WriteLine("\n");
                    Console.WriteLine("Enter the number of guests: ");
                    int nguest = Convert.ToInt32(Console.ReadLine());
                    obj1.setguestlist(nguest);

                    Console.WriteLine("\n");
                    Console.WriteLine("Choose one of the following packageoffers: ");
                    Console.WriteLine("Press 1 for Platinum packageoffer");
                    Console.WriteLine("Press 2 for Gold packageoffer");
                    Console.WriteLine("Press 3 for Silver packageoffer");
                    Console.WriteLine("Enter your choice: ");
                    int packageoffer = Convert.ToInt32(Console.ReadLine());
                    obj1.setpackageoffer(packageoffer);


                    Console.WriteLine("\n");
                    Console.WriteLine("enter your venue: ");
                    string ven = Console.ReadLine();
                    obj1.setVenue(ven);



                    int expenditure = obj1.gettotalexpenditure();


                    Console.WriteLine("Here's the details of the event you are planning for:\n");
                    Console.WriteLine("Event Name:" + obj1.nameofevent);
                    Console.WriteLine("Event Type: " + obj1.typeofevent);
                    Console.WriteLine("Event Time: " + obj1.scheduleofevent);
                    Console.WriteLine("Guest list: " + obj1.guestlist);
                    Console.WriteLine("packageoffer Selected : " + obj1.packageoffer);
                    Console.WriteLine("Selected Venue: " + obj1.venue);

                    Console.WriteLine("Your Total totalexpenditure is: " + obj1.totalexpenditure);
                }

                else
                {
                    Console.WriteLine("Exit");
                    goto label;
                }


            }
        }
    }
}
