using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStoreExample
{
    public struct KeyValue<T>
    {
        public readonly string key;
        public readonly T value;

        public KeyValue(string a, T b)
        {
            key = a;
            value = b;
        }

    }

}
