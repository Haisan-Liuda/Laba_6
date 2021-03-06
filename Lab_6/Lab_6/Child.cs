﻿using System;

namespace Lab_6
{
    class Child : Person
    {
        public override int Age
        {
            get => base.Age;
            set
            {
                if (value >= 15)
                    throw new ArgumentException("Child's age must be less than 15!");

                base.Age = value;
            }
        }

        public Child(string name, int age)
            : base(name, age)
        { }
    }
}