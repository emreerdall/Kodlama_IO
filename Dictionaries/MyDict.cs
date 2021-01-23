using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    class MyDict<K,V>
    {
        public K[] keys;
        public V[] values;

        public MyDict()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempKey = keys;
            V[] tempValue = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[keys.Length - 1] = value;

        }
        public int Count
        {
            get { return keys.Length; }
        }

        public V key(K val)
        {
            int a;
            for (a=0; a < keys.Length; a++)
            {
                if (Convert.ToString(keys[a]) == Convert.ToString(val))
                {
                    break;
                }
            }
                return values[a];
        }
    }
}
