using System;
using System.Collections.Generic;


[Serializable]
public class DictionaryExposer<TKey, TValue>
{
    public List<ValueByKey<TKey, TValue>> ExposedDictionary = new List<ValueByKey<TKey, TValue>>();

    public void ApplyDictionary(IDictionary<TKey, TValue> dictionary)
    {
        ExposedDictionary.Clear();

        foreach (var keyValuePair in dictionary)
        {
            var valueByKey = new ValueByKey<TKey, TValue>
            {
                Key = keyValuePair.Key, Value = keyValuePair.Value
            };

            ExposedDictionary.Add(valueByKey);
        }
    }

    [Serializable]
    public class ValueByKey<TKey, TValue>
    {
        public TKey Key;
        public TValue Value;
    }
}