using Microsoft.Azure.ActiveDirectory.GraphClient.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStoreExample
{
    public class MyDictionary
    {
        private KeyValue[] values = new KeyValue[10];
        private int numValues = 0;

        public object this[string key]
        {
            get
            {
                for (int i = 0; i < numValues; i++)
                {
                    if (values[i].key == key)
                        return values[i].value;
                }
                throw new KeyNotFoundException();
            }

            set
            {
                for (int i = 0; i < numValues; i++)
                {
                    if (values[i].key == key)
                    {
                        values[i] = new KeyValue();
                        return;
                    }
                }
                values[numValues++] = new KeyValue();
            }
        }   
    }
}
