using System;

namespace Task.Manager.Domain.Columns.ValueObjects
{
    public readonly struct Title
    {
        private readonly string _text;

        public Title(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException($"Name value is required");
            }

            _text = text;
        }
    }
}
