using Coffee_Machine_SOLID.AbstractClasses;

namespace Coffee_Machine_SOLID.Classes
{
    internal class WaterContainer : Container
    {
        private int _waterAmount = 0;
        public int WaterAmount
        {
            get { return _waterAmount; }
            set { _waterAmount = value; }
        }

        public WaterContainer() { }

        public override void Refill(int amount)
        {
            _waterAmount += amount;
        }
    }
}
