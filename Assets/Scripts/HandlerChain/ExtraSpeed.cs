using System;
using UnityEngine;


[Serializable]
public class ExtraSpeed : PlayerHandler
{
    [SerializeField] private float addSpeed;

    protected override void Handle(Player player) => player.Speed += addSpeed;
    protected override void Unhandle(Player player) => player.Speed -= addSpeed;
}