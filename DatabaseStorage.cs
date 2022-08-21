using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{

    //This calss defines the model for the Data that we are going to use
    internal class DatabaseStorage
    {

        public string firstName;
        public string lastName;
        public uint acctNo;
        public uint pin;
        public int balance;
        public string imageSource;

        public DatabaseStorage()
        {

            firstName = "";
            lastName = "";
            acctNo = 0;
            pin = 0;
            balance = 0;
            imageSource = "";

        }


    }
}
