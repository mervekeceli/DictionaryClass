using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryList
{
    class MyDictionary<TypeKey, TypeValue>
    {
        TypeKey[] keys;
        TypeValue[] values;

        TypeKey[] tempKeys;
        TypeValue[] tempValues;

        public MyDictionary()
        {
            keys = new TypeKey[0];
            values = new TypeValue[0];
        }

        public void Add(TypeKey k,TypeValue v)
        {
            tempKeys = keys;
            tempValues = values;

            keys = new TypeKey[keys.Length + 1];
            values = new TypeValue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = k;
            values[values.Length - 1] = v;
        }


        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key: "+keys[i]+"\tValue: "+values[i]);
            }
        }

        public int _ValuesLength
        {
            get { return values.Length; }
        }
        
        public int _keysLength
        {
            get { return keys.Length; }
        }
    }
}
