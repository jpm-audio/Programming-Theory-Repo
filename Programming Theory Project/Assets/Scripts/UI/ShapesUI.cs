using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class ShapesUI : MonoBehaviour
{
    public TextMeshProUGUI UserName;
    // Start is called before the first frame update
    void Start()
    {
        _UpdateUserNameText();
    }

    private void _UpdateUserNameText()
    {
        UserName.text = MainManager.Instance.UserName;
    }

    public void OnBackPress()
    {
        SceneManager.LoadScene(0);
    }
}
