namespace DesignPatterns.DesignPatterns.Decorator
{
    class GPU : Device
    {
        Device _device;

        public GPU(Device device)
        {
            _device = device;
        }

        internal override string GetFinalDescription()
        {
            return $"{_device.GetNonFinalDescription()} and a GPU";
        }
    }
}
