namespace DesignPatterns.DesignPatterns.Observer
{
    class ObserverExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            var forum = new Forum();
            var speaker1 = new Speaker("Pera", forum);
            var speaker2 = new Speaker("Djura", forum);

            speaker1.ExitTheForum();

            var speaker3 = new Speaker("Boba", forum);

            speaker2.ExitTheForum();
            speaker3.ExitTheForum();
        }
    }
}
