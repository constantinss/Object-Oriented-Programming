﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Turtle : Animal
    {
        // Default constructor
        public Turtle()
        {

        }

        //Constructor

        public Turtle(string name) : base(name)
        {
            this.name = name;
            base.ToString();
        }
        public Turtle(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
            base.ToString();

        }

        // Methods

        public override string ToString()
        {
            return $"Turtle: {this.name}({this.age})";
        }
    }
}
