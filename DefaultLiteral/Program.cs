using System;

namespace DefaultLiteral
{
    class Program
    {
        static void Main(string[] args)
        {
            //Previous version                        
            int[] nums = GetArrayOld<int>(4);
            Display<int>(nums);

            string[] names = GetArrayOld<string>(5, "None");
            Display<string>(names);

            //C# 7.1
            int[] nums1 = GetArray<int>(7);
            Display<int>(nums1);

            string[] names1 = GetArrayOld<string>(5, "None");
            Display<string>(names1);

            void Display<T>(T[] values) => Console.WriteLine($"[ {string.Join(", ", values)} ]");
            
            //Previous version
            T[] GetArrayOld<T>(int length, T intitalValue = default(T))
            {
                if(length < 0)
                {                
                    return default(T[]);
                }
                var array = new T[length];
                for(int i = 0; i < length; i++)
                {
                    array[i] = intitalValue;
                }
                return array;
            }

            //C# 7.1
            T[] GetArray<T>(int length, T intitalValue = default)
            {
                if(length < 0)
                {                
                    return default;
                }
                var array = new T[length];
                for(int i = 0; i < length; i++)
                {
                    array[i] = intitalValue;
                }
                return array;
            }

        }                        
    }
}
