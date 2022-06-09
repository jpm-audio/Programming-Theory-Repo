using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{

    public abstract void OnPressAction();

    public void Update()
    {
        if(GetComponent<ClickableObject>().IsClick)
        {
            OnPressAction();
        }
    }
}
