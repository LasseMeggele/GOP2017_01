using System;
using System.Collections.Generic;

namespace GOP_01
{
    internal class Ils91
    {
        protected static void Main(string[] args)
        {
            var c1 = new Computer(
                model: "HP Elitebook 840 G3", 
                serialnumber: "qwerwert"
            );
            var c2 = new Computer(
                manufacturer: "LENOVO", 
                model: "Thinkpad X260", 
                description: null, 
                serialnumber: "234asdf345", 
                uuid: null,
                macAddressList: null
            );
            var c3 = new Computer();

            var macs = new List<string>{"12-34-56-78-90-AB", "23-45-67-89-0A-BC"};

            c2.MacAddress = macs;
            c2.MacAddress.Add("34-56-78-90-AB-CD");
            

            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());


        }
    }


}
