namespace DesignPatterns.DesignPatterns.Decorator
{
    class RAM : Device
    {
        Device _device;
        int _size;

        public RAM(Device device, int size)
        {
            _device = device;
            _size = size;
        }

        internal override string GetFinalDescription()
        {
            return $"{_device.GetNonFinalDescription()}, {_size} of RAM";
        }
    }
}
