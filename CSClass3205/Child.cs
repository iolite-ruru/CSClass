﻿using System;

namespace CSClass3205
{
    public class Child : Parent
    {
        public new string variable = "hiding";

        public void Method()
        {
            Console.WriteLine("자식 메서드");
        }

        public Child() : base(10)
        {
            Console.WriteLine("Child() : base(10)");
        }

        public Child(string input) : base(input)
        {
            Console.WriteLine("Child(string input) : base(input)");
        }

        public void CountChild()
        {
            Child.counter++;
        }
    }
}