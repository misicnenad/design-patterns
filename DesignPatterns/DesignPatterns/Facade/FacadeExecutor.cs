namespace DesignPatterns.DesignPatterns.Facade
{
    class FacadeExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            var skype = new Skype();
            var vs = new VisualStudio();
            var gc = new GoogleChrome();

            skype.Open();
            skype.SeeNotifications();

            vs.Open();
            vs.OpenCurrentSolution();

            gc.Open();
            gc.OpenLevi9Academy();
            gc.StartYoutube();
        }
    }
}
