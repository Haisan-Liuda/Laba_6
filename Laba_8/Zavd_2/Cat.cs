using System;

namespace Zavd_2
    class Cat : Animal
    {
        public override string ExplainSelf()
            => base.ExplainSelf() + Environment.NewLine + "MEEOW";

        public Cat(string name, string favouriteFood)
            : base(name, favouriteFood)
        { }
    }
}