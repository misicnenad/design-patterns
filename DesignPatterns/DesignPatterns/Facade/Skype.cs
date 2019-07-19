using System;

namespace DesignPatterns.DesignPatterns.Facade
{
    class Skype
    {
        private bool _isOpen = false;

        public void Open()
        {
            _isOpen = true;
            Console.WriteLine("Open Skype");
        }

        public void SeeNotifications()
        {
            if (_isOpen)
            {
                Console.WriteLine("See Skype Notifications");
                return;
            }

            Console.WriteLine("Can't see Skype notifications until Google Chrome is open");
        }
    }
}
