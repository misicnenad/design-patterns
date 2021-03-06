﻿using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.Bridge;

namespace DesignPatterns.Factory.Factories
{
    class BridgeFactory : IFactory
    {
        public IDesignPatternExecutor GetExecutor()
        {
            return new BridgeExecutor();
        }
    }
}
