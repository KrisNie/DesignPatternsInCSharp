namespace Builder.Vehicle
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    public abstract class AbstractVehicleBuilder
    {
        protected Vehicle vehicle;

        // Gets vehicle instance
        public Vehicle Vehicle => vehicle;

        // Abstract build methods

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}