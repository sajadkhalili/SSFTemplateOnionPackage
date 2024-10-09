using SSF.SsfMediatR.Contracts.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSF.SSFMicroService.Domain.AggregateSamples.Contracts.CreateAggregateSample
{
    public record CreateAggregateSampleCommand : ICommand<CreateAggregateSampleResult>
    {
        public string Title { get; set; }

        public CreateAggregateSampleCommand(string title) => Title = title;
    }
}
