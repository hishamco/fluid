﻿using System.Collections.Generic;

namespace Fluid.Values
{
    public class FluidValueDictionaryFluidIndexable : IFluidIndexable
    {
        private readonly IDictionary<string, FluidValue> _dictionary;

        public FluidValueDictionaryFluidIndexable(IDictionary<string, FluidValue> dictionary)
        {
            _dictionary = dictionary;
        }

        public int Count => _dictionary.Count;

        public IEnumerable<string> Keys => _dictionary.Keys;

        public bool TryGetValue(string name, out FluidValue value)
        {
            return _dictionary.TryGetValue(name, out value);
        }
    }
}
