using System;

namespace MyLibrary
{
    /// <summary>
    /// A Recursive Approach
    /// </summary>
    public class CharSequence
    {
        int size;
        char[] seq;
        public CharSequence(int size)
        {
            this.size = size;
            seq = new char[this.size];
        }
        /// <summary>
        /// Pass start index value as 0
        /// </summary>
        /// <param name="it"></param>
        public void getCharSequence(int index)
        {
            if (index < this.size)
            {
                for (int i = 0; i < 26; i++)
                {
                    seq[index] = (char)(i + 'A');
                    getCharSequence(index + 1);
                }
            }
            else
            {
                Console.WriteLine(seq);
            }
        }
    }
}
