using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private IUnitFactory unitFactory;

    public void SetUnitFactory(IUnitFactory unitFactory)
    {
        this.unitFactory = unitFactory;
    }
    void Start()
    {
        IUnit enemy = unitFactory.CreateEnemy(50);

    }

}