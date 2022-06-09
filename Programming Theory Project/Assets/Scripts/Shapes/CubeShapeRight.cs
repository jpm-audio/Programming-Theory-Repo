using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShapeRight : CubeShape
{
    public override void Action()
    {
        base.Action();
        _SpinRight();
    }

    private void _SpinRight()
    {
        transform.Rotate(Vector3.down*20);
    }

    public override void GoBack()
    {
        base.GoBack();
        transform.Rotate(Vector3.up*20);
    }
}
