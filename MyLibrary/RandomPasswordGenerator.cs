using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibrary
{
    public class RandomPasswordGenerator
    {
        /// <summary>
        /// Generates a new 10 digit random password which contains uppercase, lowercase and digit
        /// </summary>
        public void GetRandomPassword()
        {
            char[] array = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int arrLen = array.Length;
            int uCount = 0, lCount = 0, dCount = 0;
            bool flag = false;
            string passWord = "";
            Random r = new Random();
            for (int i = 0; i < 10;)
            {
                int randKey = r.Next(0, arrLen);
                if (randKey >= 0 && randKey <= 25)
                {
                    if ((flag && uCount < 3) || (!flag && uCount < 4))
                    {
                        char temp = array[randKey];
                        passWord = passWord + temp;
                        uCount++;
                        if (uCount == 4)
                        {
                            flag = true;
                        }
                        i++;
                    }
                }
                else if (randKey >= 26 && randKey <= 51)
                {
                    if ((flag && lCount < 3) || (!flag && lCount < 4))
                    {
                        char temp = array[randKey];
                        passWord = passWord + temp;
                        lCount++;
                        if (lCount == 4)
                        {
                            flag = true;
                        }
                        i++;
                    }
                }
                else if (randKey >= 52 && randKey <= 61)
                {
                    if ((flag && dCount < 3) || (!flag && dCount < 4))
                    {
                        char temp = array[randKey];
                        passWord = passWord + temp;
                        dCount++;
                        if (dCount == 4)
                        {
                            flag = true;
                        }
                        i++;
                    }
                }
            }
            Console.WriteLine(passWord);
            //Console.WriteLine(uCount + " " + lCount + " " + dCount);//count
        }
    }
}
