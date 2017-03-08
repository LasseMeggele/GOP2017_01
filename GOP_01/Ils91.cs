using System;
using System.Collections.Generic;
using System.Linq;

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
                price: 6500.0m,
                purchaseDate: new DateTime(2017, 1, 2), 
                serialnumber: "234asdf345", 
                uuid: null,
                macAddressList: null,
                serviceContract: new ServiceContract()
            );
            var c3 = new Computer();

            var macs = new List<string>{"12-34-56-78-90-AB", "23-45-67-89-0A-BC"};

            c2.MacAddress = macs;
            c2.MacAddress.Add("34-56-78-90-AB-CD");
            
            var u1 = new User("lamg", "Lasse Meggele", "IOS", null, new List<AssetItem>(){c2});


            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());

            Console.WriteLine(u1.ToString());
            Console.WriteLine(u1.AssetsItems);

        }
    }


}
