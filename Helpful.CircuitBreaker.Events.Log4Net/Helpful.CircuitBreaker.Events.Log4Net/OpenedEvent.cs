using System;
using log4net;

namespace Helpful.CircuitBreaker.Events.Log4Net
{
    public class OpenedEvent : IOpenedEvent
    {
        private readonly ILog _log;

        public OpenedEvent()
        {
            _log = LogManager.GetLogger("OpenedEvent");
        }

        public void RaiseEvent(ICircuitBreakerDefinition breakerDefinition, BreakerOpenReason reason, Exception exception)
        {
            _log.Warn(new {BreakerDefinition = breakerDefinition, BreakerOpenReason = reason}, exception);
        }
    }
}