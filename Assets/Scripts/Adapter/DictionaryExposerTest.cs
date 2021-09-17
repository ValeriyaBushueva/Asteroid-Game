using System.Collections.Generic;
using UnityEngine;


public class DictionaryExposerTest : MonoBehaviour
{
    [SerializeField] private DictionaryExposer<string, int> exposedDictionary;
    
    private Dictionary<string, int> testDictionary = new Dictionary<string, int>
    {
        {"test1", 50}, {"test2", 10}, {"test3", 55}, {"test4", 77}, {"test5", 81},
    };

    [ContextMenu("TEST")]
    public void TEST()
    {
        exposedDictionary.ApplyDictionary(testDictionary);    
    }
}
