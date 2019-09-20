using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ContactRec
    {
        public int ID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string phoneNum { get; set; }

        public string homeNum { get; set; }

        public string businessNum { get; set; }

        public string address { get; set; }

        public string notes { get; set; }


        public Boolean active { get; set; }


    }
}
