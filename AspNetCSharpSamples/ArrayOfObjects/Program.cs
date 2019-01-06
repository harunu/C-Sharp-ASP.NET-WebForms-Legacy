using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Collections ;

namespace ArrayOfObjects
{
    class Program
    {

        static void Main(string[] args)
        {

            List<Automobile> inventory = new List<Automobile>();

            //ArrayList inventory = new ArrayList();
            //Automobile[] inventory = new Automobile[5];

            Automobile a1 = new Automobile();

            a1.Make = "Dodge";
            a1.Model = "Dart";
            a1.Year = 1976;
            a1.ExteriorColur = "Green";
            a1.Miles = 111001;


            Automobile a2 = new Automobile();

            a2.Make = "Oldsmobile";
            a2.Model = "Cutlas Supreme";
            a2.Year = 1985;
            a2.ExteriorColur = "Silver";
            a2.Miles = 750;



            Automobile a3 = new Automobile();

            a3.Make = "Geo";
            a3.Model = "Prism";
            a3.Year = 1992;
            a3.ExteriorColur = "Green";
            a3.Miles = 154001;

            
            Automobile a4 = new Automobile();

            a4.Make = "Nissan";
            a4.Model = "Altima";
            a4.Year = 2000;
            a4.ExteriorColur = "Black";
            a4.Miles = 105001;


            Automobile a5 = new Automobile();

            a5.Make = "BMW";
            a5.Model = "745Li";
            a5.Year = 2005;
            a5.ExteriorColur = "Black";
            a5.Miles = 70001;

            inventory.Add(a1);
            inventory.Add(a2);
            inventory.Add(a3);
            inventory.Add(a4);
            inventory.Add(a5);




             //inventory[0] = a1;
             //inventory[1] = a2;
             //inventory[2] = a3;
             //inventory[3] = a4;
             //inventory[4] = a5;


            Console.WriteLine ("Our current inventory includes:");


            //for(int i = 0 ; i<5 ; i++){
            //inventory[i].Print();
            //}


            foreach (object item in inventory) {


                Automobile auto = (Automobile)item;
                auto.Print();   
            }

            Console.WriteLine ("");
            Console.WriteLine ("We have a special promotion on this vehicle:");

        //inventory [1].Print();

        //    Console.ReadLine();

            Automobile promoAuto = (Automobile)inventory[1];
            promoAuto.Print();

            Console.ReadLine();

        }
    }
}
