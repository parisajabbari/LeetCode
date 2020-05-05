using System;
using System.Collections.Generic;

namespace project
{
    public class NumberComplement
    {
        public static int FindComplement(int num) 
        {
            
            
            Stack<int> binary = new Stack<int>();
            var output = 0;

            for (int i = 0; num > 0; i++)
            {
                
                binary.Push(num % 2);
                num = num / 2;
            }    

            Stack<int> compelementNumberStack = new Stack<int>();
            foreach (var number in binary)
            {
                if(number == 1 )
                {
                    compelementNumberStack.Push(0);
                }
                else
                {
                    compelementNumberStack.Push(1);
                }               
            }

            int j = 0;
            while(compelementNumberStack.Count > 0)
            {
                output += compelementNumberStack.Pop()* (int)Math.Pow(2, j);
                j++;
            }
            
            return output;
        }
    }
}
