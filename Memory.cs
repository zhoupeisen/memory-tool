using System;

namespace project
{
    class Memory
    {
        private string thought;

        public Memory(string a) //constructor for memory
        {
            thought = a;
        }

        public string getMemory() //return private memory
        {
            return thought;
        }
    }
}
