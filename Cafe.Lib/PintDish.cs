using System;

namespace Cafe.Lib
{
    public class PintDish
    {
        public delegate void PinstartedHandler(object sender,EventArgs e);
        public event PinstartedHandler PinStarted;
        public int PintCount { get; private set; }
        public int MaxPints { get; }

        public PintDish(int maxPints)
        {
            MaxPints = maxPints;
        }

        public void AddPint()
        {
            if (PintCount >= MaxPints) throw new Exception("Dish full, no more pints for you!");
            PinStarted?.Invoke(this, EventArgs.Empty);
            PintCount++;
        }
    }
}