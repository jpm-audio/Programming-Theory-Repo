using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class MainUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnGoPress()
    {
        SceneManager.LoadScene(1);
    }
    
}
