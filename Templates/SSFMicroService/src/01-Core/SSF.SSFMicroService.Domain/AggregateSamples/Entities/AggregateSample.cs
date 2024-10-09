using SSF.Core.Domain.Entities;
using SSF.Core.Domain.ValueObjects;

namespace SSF.SSFMicroService.Domain.AggregateSamples.Entities
{
    public class AggregateSample : AggregateRoot<long>
    {
        private AggregateSample(PersianString title)
        {
            Title = title;
        }
        public PersianString Title { get; set; }

        public AggregateSample()
        {

        }
    }
}
