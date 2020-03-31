using System;

namespace Task.Manager.Domain.Tasks.ValueObjects
{
    public readonly struct Description
    {
        private readonly string _text;

        public Description(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException($"Description value is required");
            }

            _text = text;
        }
    }
}
