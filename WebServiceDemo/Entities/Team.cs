using System.Collections;
using System.Collections.Generic;

namespace WebServiceDemo.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Player> Players { get; set; }
        public Person Coach { get; set; }
    }
}
