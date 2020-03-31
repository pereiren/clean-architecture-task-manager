using System;

namespace Task.Manager.Domain.Tasks.ValueObjects
{
    public readonly struct AcceptanceCriteria
    {
        private readonly string _text;

        public AcceptanceCriteria(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException($"AcceptanceCriteria value is required");
            }

            _text = text;
        }
    }
}
