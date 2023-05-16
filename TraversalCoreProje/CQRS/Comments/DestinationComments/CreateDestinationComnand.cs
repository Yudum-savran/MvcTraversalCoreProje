using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.CQRS.Comments.DestinationComments
{
    public class CreateDestinationComnand
    {
        public int MyProperty { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public int Capacity { get; set; }
    }
}
