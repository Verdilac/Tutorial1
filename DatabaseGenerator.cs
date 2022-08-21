using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tutorial1
{
    public class DatabaseGenerator
    {
        List<DatabaseStorage> datapoints;


        public DatabaseGenerator()
        { 
            datapoints = new List<DatabaseStorage>();

            String[] firstNamePool = { "johny","matt","emilly","karthik","kelly","romerez","peublo","jenniffer","anya","peter"};
            String[] lastNamePool = { "fernandez", "williams", "rodriguez", "lopez", "robinson", "walker", "martinez", "davis", "lee","henderson" };

          


            string imgurl = "https://picsum.photos/id/";


            Random random = new Random(1);



            for(int i= 0;i < 200; i++)
            {
                DatabaseStorage client = new DatabaseStorage();
                client.firstName  = firstNamePool[random.Next(0,firstNamePool.Length)];
                client.lastName = lastNamePool[random.Next(0,lastNamePool.Length)];
                client.acctNo = (uint)random.Next(100000, 1000000);
                client.pin = (uint)random.Next(1000, 10000);
                client.balance = random.Next(0, 1000000);
                client.imageSource = imgurl + random.Next(1,100) + "/200/300";
               

                datapoints.Add(client);
            }


        
        }







        public string GetFirstNameByIndex(int index)
        {
            return datapoints[index -1  ].firstName;
        }
        public string GetLastNameByIndex(int index)
        {
            return datapoints[index - 1].lastName;
        }


        public uint GetAcctNoByIndex(int index)
        {
            return  datapoints[index - 1].acctNo;
        }

        public uint GetpinByIndex(int index)
        {
            return datapoints[index - 1].pin;
        }


        public int GetBalanceByIndex(int index)
        {
            return datapoints[index - 1].balance;
        }

        public int GetNumRecords()
        {
            return datapoints.Count;
        }

        public string GetImageByIndex(int index)
        {
            return datapoints[index ].imageSource;
        }

    }
}
