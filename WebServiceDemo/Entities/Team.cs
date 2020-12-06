using System.Collections;

namespace WebServiceDemo.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public IEnumerable Players { get; set; }
        public Person Coach { get; set; }
    }
}
