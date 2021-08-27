using UnityEngine;

public class Enemy :MonoBehaviour, IUnit
{
    
    public float Hp { get; }

    public Enemy(float hp)
    {
        this.Hp = hp;
    }
}
