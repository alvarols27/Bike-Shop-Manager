using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    [Serializable]
    public class Hybrid : Bike
    {
        //Fields
        private EnumHybridType hybridType;

        //Public Property
        public EnumHybridType HybridType
        {
            get { return this.hybridType; }
            set { this.hybridType = value; }
        }

        //Methods
        //The following functions (Methods) are known as functions overloading

        //This is a STATIC POLYMORPHISM known as compile-time polymorphism (each overloaded function has to behave according to the recieving arguments)

        //Public Default Constructor (with parameters)
        //Overloaded Constructors
        public Hybrid() : base() //with no parameters
        {
            this.hybridType = EnumHybridType.Undefined;
        }

        public Hybrid(int serialNumber, int made, string model, double speed, double wheelSize) : base(serialNumber, made, model, speed, wheelSize)
        {
            this.hybridType = EnumHybridType.Undefined;
        }

        public Hybrid(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType) : base(serialNumber, made, model, speed, wheelSize, frameType)
        {
            this.hybridType = EnumHybridType.Undefined;
        }

        public Hybrid(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate)
        {
            this.hybridType = EnumHybridType.Undefined;
        }

        public Hybrid(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color)
        {
            this.hybridType = EnumHybridType.Undefined;
        }

        public Hybrid(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color, EnumBikeType type) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color, type)
        {
            this.hybridType = EnumHybridType.Undefined;
        }

        public Hybrid(int serialNumber, int made, string model, double speed, double wheelSize, EnumFrameType frameType, Date madeDate, EnumColor color, EnumBikeType type, EnumHybridType hybridType) : base(serialNumber, made, model, speed, wheelSize, frameType, madeDate, color, type)
        {
            this.hybridType = hybridType;
        }
        
        // - 2: Methods
        //The following functions (Methods) are known as functions overriding
        //We have many overridden functions

        //This is a DYNAMIC POLYMORPHISM (known as run-time polymorphism)
        //Run-time means execution time
        public override string GetState()
        {
            string state;
            state = base.GetState() + " | " + "Hybrid Type: " + this.hybridType;
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

        public override double GetMaxSpeed()
        {
            return 25;
        }
    }
}
