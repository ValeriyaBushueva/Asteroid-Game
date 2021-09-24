using System;
using UnityEngine;


[Serializable]
public class ExtraAcceleration : PlayerHandler
{
    [SerializeField] private float addAcceleration;

    protected override void Handle(Player player) => player.Acceleration += addAcceleration;

    protected override void Unhandle(Player player) => player.Acceleration -= addAcceleration;
}