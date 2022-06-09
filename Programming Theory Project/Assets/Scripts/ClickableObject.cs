using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public bool IsClick {get; private set;} = false;

    void Update()
    {
        IsClick = false;
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100.0f))
            {
                if(hit.transform != null && hit.transform.gameObject == gameObject)
                {
                    IsClick = true;
                }
            }
        }
    }
}
