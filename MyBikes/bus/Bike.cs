using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MyBikes.bus
{
    [Serializable]
    [XmlInclude(typeof(Mountain))]
    [XmlInclude(typeof(Road))]
    [XmlInclude(typeof(Electric))]
    [XmlInclude(typeof(Hybrid))]

    public abstract class Bike : Object, IMovable, IPrintable
    {
        //Data member: (private fields)
        //Fields

        private int serialNumber;
        private int made;
        private string model;
        private double speed;
        private double wheelSize;
        private EnumFrameType frameType;
        private Date madeDate;
        private EnumColor color;
        private EnumBikeType type;

        //Properties
        public int SerialNumber
        {
            get { return this.serialNumber; }
            set { serialNumber = value; }
        }

        public int Made
        {
            get { return this.made; }
            set { made = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { model = value; }
        }

        public double Speed
        {
            get { return this.speed; }
            set { speed = value; }
        }

        public double WheelSize
        {
            get { return this.wheelSize; }
            set { wheelSize = value; }
        }

        public EnumFrameType FrameType
        {
            get { return this.frameType; }
            set { frameType = value; }
        }

        public Date MadeDate
        {
            get { return this.madeDate; }
            set { madeDate = value; }
        }

        public EnumColor Color
        {
            get { return this.color; }
            set { color = value; }
        }

        public EnumBikeType Type 
        {
            get { return this.type; }
            set { type = value; }
        }

        //Methods
        //The following functions (Methods) are known as functions overloading
        //We have 6 overladed functions

        //This is a STATIC POLYMORPHISM known as compile-time polymorphism (each of the 6 overloaded functions has to behave according to the recieving arguments)
        public Bike()
        {
            this.serialNumber = 0;
            this.made = 0;
            this.model = "";
            this.speed = 0.0;
            this.wheelSize = 0.0;
            this.frameType = EnumFrameType.Undefined;
            this.madeDate = new Date();
            this.color = EnumColor.Undefined;
            this.type = EnumBikeType.Undefined;
        }

        public Bike(int serialNumber, int made, string model, double speed, double wheelSize)
        {
            this.serialNumber = serialNumber;
            this.made = made;
            this.model = model;
            this.speed = speed;
            this.wheelSize = wheelSize;
            this.frameType = EnumFrameType.Undefined;
            this.madeDate = new Date();
            this.color = EnumColor.Undefined;
            this.type = EnumBikeType.Undefined;
        }

        public Bike(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType)
        {
            this.serialNumber = serialNumber;
            this.made = made;
            this.model = model;
            this.speed = speed;
            this.wheelSize = wheelSize;
            this.frameType = frameType;
            this.madeDate = new Date();
            this.color = EnumColor.Undefined;
            this.type = EnumBikeType.Undefined;
        }

        public Bike(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate)
        {
            this.serialNumber = serialNumber;
            this.made = made;
            this.model = model;
            this.speed = speed;
            this.wheelSize = wheelSize;
            this.frameType = frameType;
            this.madeDate = madeDate;
            this.color = EnumColor.Undefined;
            this.type = EnumBikeType.Undefined;
        }

        public Bike(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color)
        {
            this.serialNumber = serialNumber;
            this.made = made;
            this.model = model;
            this.speed = speed;
            this.wheelSize = wheelSize;
            this.frameType = frameType;
            this.madeDate = madeDate;
            this.color = color;
            this.type = EnumBikeType.Undefined;
        }

        public Bike(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color, EnumBikeType type)
        {
            this.serialNumber = serialNumber;
            this.made = made;
            this.model = model;
            this.speed = speed;
            this.wheelSize = wheelSize;
            this.frameType = frameType;
            this.madeDate = madeDate;
            this.color = color;
            this.type = type;
        }

        // - 2: Methods
        //The following functions (Methods) are known as functions overriding
        //We have many overridden functions

        //This is a DYNAMIC POLYMORPHISM (known as run-time polymorphism)
        //Run-time means execution time

        public virtual string GetState()
        {
            string state;
            state = "Serial Nº " + this.serialNumber + " | " + "Type: " + this.type + " | " + "Made: "+ this.made + " | " + "Model: " + this.model + " | " + "Speed: " + this.speed + " km/h" + " | " + "Wheel Size: " + this.wheelSize + " | " + "Frame Type: " + this.frameType + " | " + "Color: " + this.color + " | " + "Made Date: " + this.madeDate.GetDateState();
            return state;
        }

        //remains virtual and returns 20, so it can be overridden
        public virtual double GetMaxSpeed()
        {
            return 20;
        }

        //remains abstract
        public abstract void SpeedUp(double newSpeed);
    }
}