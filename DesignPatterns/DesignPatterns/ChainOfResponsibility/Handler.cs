namespace DesignPatterns.DesignPatterns.ChainOfResponsibility
{
    class Handler
    {
        Handler _next;

        public void Add(Handler handler)
        {
            if (_next != null)
            {
                _next.Add(handler);
            }
            else
            {
                _next = handler;
            }
        }

        public virtual void Handle(int value)
        {
            _next?.Handle(value);
        }
    }
}
