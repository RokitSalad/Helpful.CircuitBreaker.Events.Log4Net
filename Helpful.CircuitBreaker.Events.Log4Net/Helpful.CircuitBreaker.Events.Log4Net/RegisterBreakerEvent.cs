using log4net;

namespace Helpful.CircuitBreaker.Events.Log4Net
{
    internal class RegisterBreakerEvent : IRegisterBreakerEvent
    {
        private readonly ILog _log;

        public RegisterBreakerEvent()
        {
            _log = LogManager.GetLogger("RegisterBreakerEvent");
        }

        public void RaiseEvent(ICircuitBreakerDefinition breakerDefinition)
        {
            _log.Warn(new { BreakerDefinition = breakerDefinition });
        }
    }
}