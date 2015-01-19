namespace Helpful.CircuitBreaker.Events.Log4Net
{
    public class EventFactory : IEventFactory
    {
        private readonly IClosedEvent _closedEvent;
        private readonly IOpenedEvent _openedEvent;
        private readonly IRegisterBreakerEvent _registerBreakerEvent;
        private readonly ITryingToCloseEvent _tryingToCloseEvent;
        private readonly IUnregisterBreakerEvent _unregisterBreakerEvent;
        private readonly ITolleratedOpenEvent _tolleratedOpenEvent;

        public EventFactory()
        {
            _closedEvent = new ClosedEvent();
            _openedEvent = new OpenedEvent();
            _registerBreakerEvent = new RegisterBreakerEvent();
            _tryingToCloseEvent = new TryingToCloseEvent();
            _unregisterBreakerEvent = new UnregisterBreakerEvent();
            _tolleratedOpenEvent = new TolleratedOpenEvent();
        }

        public IClosedEvent GetClosedEvent()
        {
            return _closedEvent;
        }

        public IOpenedEvent GetOpenedEvent()
        {
            return _openedEvent;
        }

        public ITryingToCloseEvent GetTriedToCloseEvent()
        {
            return _tryingToCloseEvent;
        }

        public IUnregisterBreakerEvent GetUnregisterBreakerEvent()
        {
            return _unregisterBreakerEvent;
        }

        public IRegisterBreakerEvent GetRegisterBreakerEvent()
        {
            return _registerBreakerEvent;
        }

        public ITolleratedOpenEvent GetTolleratedOpenEvent()
        {
            return _tolleratedOpenEvent;
        }
    }
}
