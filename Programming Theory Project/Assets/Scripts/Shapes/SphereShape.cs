using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereShape : Shape
{
    public override void OnPressAction()
    {
        Jump();
    }

    public void Jump()
    {
        transform.position += Vector3.up;
        Invoke("GoBack", 0.1f);
    }

    public void GoBack()
    {
        transform.position += Vector3.down;
    }
}
