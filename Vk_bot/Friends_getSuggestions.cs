using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vk_bot
{
    internal class Friends_getSuggestions
    {
        public Response response { get; set; }

        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }
        public class Item
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public bool can_access_closed { get; set; }
            public bool is_closed { get; set; }
        }
    }
}
