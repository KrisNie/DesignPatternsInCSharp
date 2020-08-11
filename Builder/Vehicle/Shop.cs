namespace Builder.Vehicle
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    class Shop
    {
        // The Director is only responsible for executing the building steps in a
        // particular sequence. It is helpful when producing products according to a
        // specific order or configuration. Strictly speaking, the Director class is
        // optional, since the client can control builders directly.
        private AbstractVehicleBuilder _vehicleBuilder;

        public AbstractVehicleBuilder Builder
        {
            get => _vehicleBuilder;
            set { _vehicleBuilder = value; }
        }

        // Builder uses a complex series of steps
        public void Construct()
        {
            _vehicleBuilder.BuildFrame();
            _vehicleBuilder.BuildEngine();
            _vehicleBuilder.BuildWheels();
            _vehicleBuilder.BuildDoors();
        }

        public void Construct(AbstractVehicleBuilder abstractVehicleBuilder)
        {
            _vehicleBuilder = abstractVehicleBuilder;
            _vehicleBuilder.BuildFrame();
            _vehicleBuilder.BuildEngine();
            _vehicleBuilder.BuildWheels();
            _vehicleBuilder.BuildDoors();
        }
    }
}