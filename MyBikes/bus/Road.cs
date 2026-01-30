using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    [Serializable]
    public class Road : Bike
    {
        //Fields
        private double seatHeight;

        //Public Property
        public double SeatHeight
        {
            get { return seatHeight; }
            set { seatHeight = value; }
        }

        //Methods
        //The following functions (Methods) are known as functions overloading

        //This is a STATIC POLYMORPHISM known as compile-time polymorphism (each overloaded function has to behave according to the recieving arguments)

        //Public Default Constructor (with parameters)
        //Overloaded Constructors
        public Road() : base() //with no parameters
        {
            this.seatHeight = 0.0;
        }

        public Road(int serialNumber, int made, string model, double speed, double wheelSize) : base(serialNumber, made, model, speed, wheelSize)
        {
            this.seatHeight = 0.0;
        }

        public Road(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType) : base(serialNumber, made, model, speed, wheelSize, frameType)
        {
            this.seatHeight = 0.0;
        }

        public Road(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate)
        {
            this.seatHeight = 0.0;
        }

        public Road(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color)
        {
            this.seatHeight = 0.0;
        }

        public Road(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color, EnumBikeType type) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color, type)
        {
            this.seatHeight = 0.0;
        }

        public Road(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color, EnumBikeType type, double seatHeight) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color, type)
        {
            this.seatHeight = seatHeight;
        }

        // - 2: Methods
        //The following functions (Methods) are known as functions overriding
        //We have many overridden functions

        //This is a DYNAMIC POLYMORPHISM (known as run-time polymorphism)
        //Run-time means execution time
        public override string GetState()
        {
            string state;
            state = base.GetState() + " | " + "Seat Height: " + this.seatHeight;
            return state;
        }

        //the Road class does not need to override the virtual method Reset() of the base class counter.
        //because the Road will reset the value to 0 (it has the same behavior as the base class.

        //Overridden method
        //IMovable interface

        public override void SpeedUp(double newSpeed)
        {
            if (Speed + newSpeed <= GetMaxSpeed())
            {
                Speed += newSpeed;
            }
        }

        public override double GetMaxSpeed()
        {
            return 40;
        }
    }
}
