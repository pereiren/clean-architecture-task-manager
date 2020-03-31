using System;

namespace Task.Manager.Domain.Boards.ValueObjects
{
    public readonly struct Name
    {
        private readonly string _text;

        public Name(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException($"Name value is required");
            }

            _text = text;
        }
    }
}
