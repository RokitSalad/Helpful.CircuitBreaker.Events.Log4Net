using log4net;

namespace Helpful.CircuitBreaker.Events.Log4Net
{
    internal class TryingToCloseEvent : ITryingToCloseEvent
    {
        private readonly ILog _log;

        public TryingToCloseEvent()
        {
            _log = LogManager.GetLogger("TryingToCloseEvent");
        }

        public void RaiseEvent(ICircuitBreakerDefinition breakerDefinition)
        {
            _log.Warn(new { BreakerDefinition = breakerDefinition });
        }
    }
}