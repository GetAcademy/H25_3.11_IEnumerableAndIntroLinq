namespace IEnumerableAndIntroLinq.BuilderPattern
{
    using System;
    using System.Collections.Generic;

    public class StringQuery
    {
        private readonly string[] _source;
        private readonly List<Func<string[], string[]>> _steps;

        public StringQuery(string[] source)
        {
            _source = source;
            _steps = new List<Func<string[], string[]>>();
        }

        private StringQuery(string[] source, List<Func<string[], string[]>> steps)
        {
            _source = source;
            _steps = steps;
        }

        public StringQuery WhereLengthGreaterThan(int length)
        {
            var newSteps = new List<Func<string[], string[]>>(_steps);

            newSteps.Add(input =>
            {
                var result = new List<string>();
                foreach (var s in input)
                    if (s.Length > length)
                        result.Add(s);

                return result.ToArray();
            });

            return new StringQuery(_source, newSteps);
        }

        public StringQuery ToUpper()
        {
            var newSteps = new List<Func<string[], string[]>>(_steps);

            newSteps.Add(input =>
            {
                var result = new string[input.Length];
                for (int i = 0; i < input.Length; i++)
                    result[i] = input[i].ToUpper();

                return result;
            });

            return new StringQuery(_source, newSteps);
        }

        public StringQuery Reverse()
        {
            var newSteps = new List<Func<string[], string[]>>(_steps);

            newSteps.Add(input =>
            {
                var result = new string[input.Length];
                for (int i = 0; i < input.Length; i++)
                    result[i] = input[input.Length - 1 - i];

                return result;
            });

            return new StringQuery(_source, newSteps);
        }

        public string[] ToArray()
        {
            var current = _source;

            foreach (var step in _steps)
                current = step(current);

            return current;
        }
    }

}
