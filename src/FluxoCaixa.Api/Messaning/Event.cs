namespace FluxoCaixa.Api.Messaning
{
    public class Event
    {
        public string MessageType { get; protected set; }
        public DateTime Timestamp { get; private set; }

        protected Event()
        {
            MessageType = GetType().Name;
            Timestamp = DateTime.Now;
        }
    }
}
