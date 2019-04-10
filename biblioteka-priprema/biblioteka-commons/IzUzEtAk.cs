using System;

namespace biblioteka_commons
{
    public class IzUzEtAk : Exception
    {
        public IzUzEtAk(string message) : base(message)
        {
        }

        public string RaZlOg => Message;
    }
}