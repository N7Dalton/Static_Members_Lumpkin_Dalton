using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Members_Lumpkin_Dalton
{
   
        static class Calculate
        {
            //its some float
            static float result;

            static Calculate()
            {
                //sets float that is never used btw
                result = 0.0f;
            }


            //The Methods that do things
            public static float Add(int int1, int int2)
            {
                return (int1 + int2);
            }

            public static float Subtract(int int1, int int2)
            {
                return (int1 - int2);
            }

            public static float Multiply(int int1, int int2)
            {
                return (int1 * int2);
            }

            public static float Divide(int int1, int int2)
            {
                return (int1 / int2);
            }

            public static float Add(float float1, float float2)
            {
                return (float1 + float2);
            }

            public static float Subtract(float float1, float float2)
            {
                return (float1 - float2);
            }

            public static float Multiply(float float1, float float2)
            {
                return (float1 * float2);
            }

            public static float Divide(float float1, float float2)
            {
                return (float1 / float2);
            }
        }
    
}
