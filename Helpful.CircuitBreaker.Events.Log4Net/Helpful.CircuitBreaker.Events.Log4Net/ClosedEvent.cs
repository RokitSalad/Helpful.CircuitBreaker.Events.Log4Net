using log4net;

namespace Helpful.CircuitBreaker.Events.Log4Net
{
    internal class ClosedEvent : IClosedEvent
    {
        private readonly ILog _log;

        public ClosedEvent()
        {
            _log = LogManager.GetLogger("ClosedEvent");
        }

        public void RaiseEvent(ICircuitBreakerDefinition breakerDefinition)
        {
            _log.Warn(new { BreakerDefinition = breakerDefinition });
        }
    }
}
