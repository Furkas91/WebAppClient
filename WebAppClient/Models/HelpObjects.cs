using System.Collections.Generic;

namespace WebAppClient.Models
{
    public class HelpObjects
    {
        
        public IEnumerable<Consumer> Consumers;
        public IEnumerable<Barber> Barbers;
        public IEnumerable<Haircut> Haircuts;

        public HelpObjects(IEnumerable<Consumer> consumers, IEnumerable<Barber> barbers, IEnumerable<Haircut> haircut)
        {
            Consumers = consumers;
            Barbers = barbers;
            Haircuts = haircut;
        }
    }
}