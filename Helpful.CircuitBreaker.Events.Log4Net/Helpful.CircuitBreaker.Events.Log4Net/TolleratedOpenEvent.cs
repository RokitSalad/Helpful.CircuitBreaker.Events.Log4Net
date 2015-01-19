using System;
using log4net;

namespace Helpful.CircuitBreaker.Events.Log4Net
{
    public class TolleratedOpenEvent : ITolleratedOpenEvent
    {
        private readonly ILog _log;

        public TolleratedOpenEvent()
        {
            _log = LogManager.GetLogger("TolleratedOpenEvent");
        }

        public void RaiseEvent(short tolleratedOpenEventCount, ICircuitBreakerDefinition breakerDefinition, BreakerOpenReason reason,
            Exception exception)
        {
            _log.Warn(new { BreakerDefinition = breakerDefinition, BreakerOpenReason = reason, TolleratedOpenEventCount = tolleratedOpenEventCount }, exception);
        }
    }
}