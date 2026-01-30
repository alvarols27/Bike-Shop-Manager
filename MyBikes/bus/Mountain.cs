using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    [Serializable]
    public class Mountain : Bike
    {
        //Fields
        private EnumSuspension suspension;
        private double heightFromGround;

        //Public Property
        public EnumSuspension Suspension
        {
            get { return this.suspension; }
            set { this.suspension = value;}
        }

        public double HeightFromGround
        {
            get { return this.heightFromGround; }
            set { this.heightFromGround = value; }
        }

        //Methods
        //The following functions (Methods) are known as functions overloading

        //This is a STATIC POLYMORPHISM known as compile-time polymorphism (each overloaded function has to behave according to the recieving arguments)

        //Public Default Constructor (with parameters)
        //Overloaded Constructors
        public Mountain() : base() //with no parameters
        {
            this.suspension = EnumSuspension.Undefined;
            this.heightFromGround = 0.0;
        }

        public Mountain(int serialNumber, int made, string model, double speed, double wheelSize) : base(serialNumber, made, model, speed, wheelSize)
        {
            this.suspension = EnumSuspension.Undefined;
            this.heightFromGround = 0.0;
        }

        public Mountain(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType) : base(serialNumber, made, model, speed, wheelSize, frameType)
        {
            this.suspension = EnumSuspension.Undefined;
            this.heightFromGround = 0.0;
        }

        public Mountain(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate)
        {
            this.suspension = EnumSuspension.Undefined;
            this.heightFromGround = 0.0;
        }

        public Mountain(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color)
        {
            this.suspension = EnumSuspension.Undefined;
            this.heightFromGround = 0.0;
        }

        public Mountain(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color, EnumBikeType type) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color, type)
        {
            this.suspension = EnumSuspension.Undefined;
            this.heightFromGround = 0.0;
        }

        public Mountain(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color, EnumBikeType type, EnumSuspension suspension, double heightFromGround) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color, type)
        {
            this.suspension = suspension;
            this.heightFromGround = heightFromGround;
        }

        // - 2: Methods
        //The following functions (Methods) are known as functions overriding
        //We have many overridden functions

        //This is a DYNAMIC POLYMORPHISM (known as run-time polymorphism)
        //Run-time means execution time
        public override string GetState()
        {
            string state;
            state = base.GetState() + " | " + "Suspension: " + this.suspension + " | " + "Ground Ht.: " + this.heightFromGround;
            return state;
        }

        //Overridden method
        //IMovable interface
        public override void SpeedUp(double newSpeed)
        {
            if (Speed + newSpeed <= GetMaxSpeed())
            {
                Speed += newSpeed;
            }
        }
    }
}
