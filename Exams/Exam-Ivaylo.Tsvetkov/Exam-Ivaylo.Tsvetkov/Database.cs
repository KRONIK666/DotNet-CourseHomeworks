using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace Exam_Ivaylo.Tsvetkov
{
    public class Database
    {
        public static List<Statistics> GetResults()
        {
            List<Statistics> result = new List<Statistics>();

            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
            {
                string line = reader.ReadLine();
                do
                {
                    string[] countryInfo = line.Split('|');
                    result.Add(new Statistics()
                    {
                        Country = countryInfo[0],
                        Capital = countryInfo[1],
                        Population = int.Parse(countryInfo[2])
                    });
                    line = reader.ReadLine();
                } while (line != null);
            }
            return result;
        }
    }
}