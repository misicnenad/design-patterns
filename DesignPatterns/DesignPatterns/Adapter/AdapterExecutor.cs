using System;

namespace DesignPatterns.DesignPatterns.Adapter
{
    class AdapterExecutor : IDesignPatternExecutor
    {
        public void Execute()
        {
            try
            {
                var green = new Green(0.2m);
                var adapter = new GreenToColorAdapter(green);
                Console.WriteLine(adapter);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
