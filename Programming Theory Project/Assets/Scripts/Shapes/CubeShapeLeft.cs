using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShapeLeft : CubeShape
{
    public override void Action()
    {
        base.Action();
        _SpinLeft();
    }

    private void _SpinLeft()
    {
        transform.Rotate(Vector3.up*20);
    }

    public override void GoBack()
    {
        base.GoBack();
        transform.Rotate(Vector3.down*20);
    }
}
