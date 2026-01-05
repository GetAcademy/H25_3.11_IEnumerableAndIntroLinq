using System.Collections;

namespace IEnumerableAndIntroLinq.Enumerating
{
    internal class TerjesNumberSequence : IEnumerable<int>, IEnumerator<int>
    {
        private int _number;
        private int _maxNumber;

        public TerjesNumberSequence(int maxNumber)
        {
            _maxNumber = maxNumber;
        }

        public bool MoveNext()
        {
            if (_number >= _maxNumber) return false;
            if (_number >= 1)
            {
                _number *= 2;
            }
            else
            {
                _number = 1;
            }
            return true;
        }

        public void Reset()
        {
            Console.WriteLine("Reset to 0");
            _number = 0;
        }

        int IEnumerator<int>.Current => _number;

        object? IEnumerator.Current => _number;

        public void Dispose()
        {
        }

        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
