using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace JSON_Parsing_in_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Load and Read json file using StreamReader


            String path = "./InputDoc/Expense.json";

            using (StreamReader sr = File.OpenText(path))
            {

                var json = sr.ReadToEnd();

                JArray obj = JsonConvert.DeserializeObject<JArray>(json);
                foreach (var result in obj)
                {

                    //first loop
                    string WHO = (string)result["WHO"];
                    Console.WriteLine("\n \n *** User:- " + WHO + " ");


                    //second loop
                    foreach (JObject user in result["WEEK"])
                    {
                        string NUMBER = (string)user["NUMBER"];
                        Console.WriteLine("\n Week number:- " + NUMBER + " ");

                        //third loop
                        foreach (JObject expns in user["EXPENSE"])
                        {
                            string ExpFor = (string)expns["WHAT"];
                            string ExpAmt = (string)expns["AMOUNT"];
                            Console.WriteLine("\t Expensed for:- " + ExpFor + ", Amount spent: " + ExpAmt + " ");

                        }


                    }




                }


                Console.Read();
            }
        }
    }
}
