using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShape : Shape
{
    public override void OnPressAction()
    {
        Action();
    }

    public virtual void Action()
    {
        Scale();   
        Invoke("GoBack",0.5f);
    }

    public void Scale()
    {
        transform.localScale = new Vector3(2,2,2);
    }

    public virtual void GoBack()
    {
        transform.localScale = new Vector3(1,1,1);
    }
}
