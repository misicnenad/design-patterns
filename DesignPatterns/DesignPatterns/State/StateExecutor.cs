using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DesignPatterns.State
{
    class StateExecutor : IDesignPatternExecutor
    {
        private readonly int _hoursNeccessaryToRest = 7;
        private EnergyLevel _currentEnergyLevel = EnergyLevel.SLEEPY;

        public void Execute()
        {
            while (_currentEnergyLevel != EnergyLevel.RESTED)
            {
                Console.WriteLine("Current state: " + _currentEnergyLevel.ToString());
                switch (_currentEnergyLevel)
                {
                    case EnergyLevel.SLEEPY:
                        Console.Write("How much hours will you sleep?");
                        var sleepHoursString = Console.ReadLine();
                        while (!int.TryParse(sleepHoursString, out int hours))
                        {
                            sleepHoursString = Console.ReadLine();
                        }
                        var sleepHours = int.Parse(sleepHoursString);
                        if (sleepHours < _hoursNeccessaryToRest)
                        {
                            Console.WriteLine("You'll be tired with this small amount of sleep.");
                            _currentEnergyLevel = EnergyLevel.TIRED;
                        }
                        else
                        {
                            Console.WriteLine("You slept just fine, you'll feel great today!");
                            _currentEnergyLevel = EnergyLevel.RESTED;
                        }
                        break;
                    case EnergyLevel.TIRED:
                        Console.WriteLine("You were tired all day because of low quality sleep.");
                        _currentEnergyLevel = EnergyLevel.SLEEPY;
                        break;
                }
            }
        }
    }
}
