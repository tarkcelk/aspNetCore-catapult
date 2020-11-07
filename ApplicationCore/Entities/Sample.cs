using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Sample
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProccessId { get; set; }
        public IReadOnlyCollection<SampleDetail> SampleDetails{ get; set; } 
    }
}
