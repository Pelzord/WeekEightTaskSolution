using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CarTransaction
    {
        public int TransactionId { get; set; }
        public int LocationId { get; set; }
        public int CarId { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
