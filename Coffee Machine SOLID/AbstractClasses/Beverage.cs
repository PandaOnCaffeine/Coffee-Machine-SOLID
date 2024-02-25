
namespace Coffee_Machine_SOLID.AbstractClasses
{
    internal abstract class Beverage
    {
        protected int _amount;
        public int Amount { get { return _amount; } }
        public Beverage(int cups)
        {
            _amount = cups;
        }
        public abstract void AddIngredients();
        public abstract void Brew();
    }
}
