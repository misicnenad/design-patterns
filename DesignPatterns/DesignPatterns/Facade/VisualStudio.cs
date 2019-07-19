using System;

namespace DesignPatterns.DesignPatterns.Facade
{
    class VisualStudio
    {
        private bool _isOpen = false;

        public void Open()
        {
            _isOpen = true;
            Console.WriteLine("Open Visual Studio");
        }

        public void OpenCurrentSolution()
        {
            if (_isOpen)
            {
                Console.WriteLine("Open Current Solution");
                return;
            }

            Console.WriteLine("Can't open Visual Studio until Google Chrome is open");
        }
    }
}
