using System;

namespace DesignPatterns.DesignPatterns.Facade
{
    class GoogleChrome
    {
        private bool _isOpen = false;

        public void Open()
        {
            _isOpen = true;
            Console.WriteLine("Open Google Chrome");
        }

        public void StartYoutube()
        {
            if (_isOpen)
            {
                Console.WriteLine("Start YouTube");
                return;
            }

            Console.WriteLine("Can't start YouTube until Google Chrome is open");
        }

        public void OpenLevi9Academy()
        {
            if (_isOpen)
            {
                Console.WriteLine("Open Levi9 Academy");
                return;
            }

            Console.WriteLine("Can't start YouTube until Google Chrome is open");
        }
    }
}
