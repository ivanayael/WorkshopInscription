using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopInscriptions.Data
{
    public class InscriptionItem
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime InscriptionDate { get; set; }
        public bool HasAttended { get; set; }
    }
}
