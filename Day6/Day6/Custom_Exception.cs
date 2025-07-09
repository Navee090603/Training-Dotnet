using System;


namespace Day6
{
    class Custom_Exception:ApplicationException
    {
        public Custom_Exception(string message ):base(message)
        {

        }
    }
}
