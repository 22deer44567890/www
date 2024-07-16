using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vk_bot
{
    internal class Friends_Get_id
    {
        public class Response
        {
            public int count { get; set; }
            public List<int> items { get; set; }
        }

      
        public Response response { get; set; }
      

    }
}
