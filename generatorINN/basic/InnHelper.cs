using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace generatorINN
{
    public class InnHelper
    {
        public static Random rnd = new Random();
        public static string GenerateRandomString(int max)
        {
            Random rnd = new Random();
            int l = max;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < l; i++)
            {
                builder.Append(rnd.Next(0, 10));
            }
            return builder.ToString();
        }





    }


    //string json = JsonConvert.SerializeObject(numberinn, Formatting.Indented);
}
