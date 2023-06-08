using System;

namespace Accounts_Holder.Utils
{
    public class Randomizer
    {
        Random _randomGenerator = new Random(Environment.TickCount);
        public int GetInt(int From, int To) => _randomGenerator.Next(From, To); 
        public int GetInt() => _randomGenerator.Next(); 
    }
}