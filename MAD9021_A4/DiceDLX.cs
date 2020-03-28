using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//the using keyword in this isstance in c# is used to 
//provide an alias for different name spaces so we can use them without
//reffering to the full namespace
namespace MAD9021_A4
{
    class DiceDLX : Dice
    {
        protected uint[] rolledNumbers = new uint[6];

        protected void GenerateRollStatistics()
        {
            // this method should be called after the base class roll method has been called from the Roll method below
            // this method will update the rolledNumbers array based on the new faceValue
            rolledNumbers[this.faceValue - 1]++; 
            //the this keyword in c# is used to identify a specific instance of this object
            //while this class is the blueprint of the object, the this keyword will be used to reffer
            //to any specific instance of the class 
           
        }

        public DiceDLX() : base()
        {

        }

        public DiceDLX(byte faceValue) : base(faceValue)
        {

        }

        //the new keyword in c# for overrriden methods is used to override
        //the base class version of this method in order for us to give new functionality
        //to the dervied class method instead of just using the base class version of the emthod
        public new void Draw()
        {
            // This method will draw a graphical dice using ascii graphics and display the faceValue inside the graphic
            Console.WriteLine("-----");
            Console.WriteLine("-   -");
            Console.WriteLine($"- {faceValue} -");
            Console.WriteLine("-   -");
            Console.WriteLine("-----");
        }

        public new byte Roll()
        {
            // this method will call the base class Roll method then call the GenerateRollStatistics method
            //the base keyword in c# is used to refer to the parent of the derived class, in java we would call this the super class
            base.Roll();
            GenerateRollStatistics();
            return faceValue;
        }

        public uint[] GetStatistics()
        {
            return rolledNumbers;
        }

    }
}
