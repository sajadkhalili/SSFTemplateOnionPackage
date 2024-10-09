using SSF.SsfMediatR.Contracts.Commands;
using SSF.SsfMediatR.Contracts.RequestResponse;
using SSF.SSFMicroService.Domain.AggregateSamples.Contracts.CreateAggregateSample;

namespace SSF.SSFMicroService.Application.AggregateSamples.CreateAggregateSample;

public class CreateAggregateSampleHandler : ICommandHandler<CreateAggregateSampleCommand, CreateAggregateSampleResult>
{
    public Task<CreateAggregateSampleResult> Handle(CreateAggregateSampleCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<CommandResult<CreateAggregateSampleResult>> HandleAsync(CreateAggregateSampleCommand request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
