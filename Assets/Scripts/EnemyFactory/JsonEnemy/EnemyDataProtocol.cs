using System;
using System.Collections.Generic;


[Serializable]
public class EnemyDataProtocol
{
    public Data unit;

    [Serializable]
    public class Data
    {
        public string type;
        public int health;
    }
}