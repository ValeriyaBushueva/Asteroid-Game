using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class RotationShip : IRotation
{
    private readonly Transform toRotate;
        
    public RotationShip(Transform toRotate)
    {
        this.toRotate = toRotate;
    }

    public void Rotation(Vector3 direction)
    {
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        this.toRotate.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

    }
}
