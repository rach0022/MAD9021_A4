using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAD9021_A4
{
    class Dice
    {
        protected byte faceValue = 1;
        protected const byte MIN_FACE_VAL = 1;
        protected const byte MAX_FACE_VAL = 6; 

        // random number generator with high quality seed value
        //The GUID keyword is used to denote a GUID object which is used to create a new GUID struct
        //aka Globally Unique Identifier which in this case is a 128 bit int used as a unique seed value
        private Random random = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));

        //The random keyword is used to make a Random object which in this case we make a new
        //instance of a random object to generate a random number using its built in methods

        //The ToString keyword is used to denote the toString method of the GUID object
        //which will use its built in function to convert the GUID 128 bit int to a string value
        //that can be read by other functions, other datatypes implement this function in different ways
        //but always with the purpose to return a string value representing the data given

        //int.Parse in this instance in c# is used to get the integer value from the string 
        //in this case we use the toString to get the string value of first 8 digits of the GUID 
        //and then we parse the int from that 8 chracters while also telling the parseInt fucntion
        //that the string we are giving it is a hex number so we require a hex number back

        public Dice()
        {

        }

        public Dice(byte faceValue) // overloaded constructor
        {
            setFaceValue(faceValue); 
        }

        public byte Roll()
        {
            //the convert keyword is used to access the Convert object
            //which is a static object that is used to convert a base data type
            //like int, uint, etc to another base data type. It is a static class
            faceValue = Convert.ToByte(random.Next(MIN_FACE_VAL, MAX_FACE_VAL + 1));
            return faceValue;
        }

        public void Draw()
        {
            //The console keyword access the Console object which is used
            //for all input, output and error streams for console applications
            Console.WriteLine(faceValue);
        }

        public byte GetFaceValue() { return faceValue; }

        protected void setFaceValue(byte faceValue) {
            if (faceValue <= MAX_FACE_VAL && faceValue >= MIN_FACE_VAL)
            {
                this.faceValue = faceValue;
            }
        }

        
    }

}

