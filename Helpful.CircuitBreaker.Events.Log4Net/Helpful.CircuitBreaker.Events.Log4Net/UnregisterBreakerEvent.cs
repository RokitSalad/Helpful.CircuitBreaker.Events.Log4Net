using log4net;

namespace Helpful.CircuitBreaker.Events.Log4Net
{
    internal class UnregisterBreakerEvent : IUnregisterBreakerEvent
    {
        private readonly ILog _log;

        public UnregisterBreakerEvent()
        {
            _log = LogManager.GetLogger("UnregisterBreakerEvent");
        }

        public void RaiseEvent(ICircuitBreakerDefinition breakerDefinition)
        {
            _log.Warn(new { BreakerDefinition = breakerDefinition });
        }
    }
}