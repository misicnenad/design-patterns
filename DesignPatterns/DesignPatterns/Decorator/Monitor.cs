namespace DesignPatterns.DesignPatterns.Decorator
{
    class Monitor : Device
    {
        Device _device;

        public Monitor(Device device)
        {
            _device = device;
        }

        internal override string GetFinalDescription()
        {
            return $"{_device.GetNonFinalDescription()}, a Monitor";
        }
    }
}
