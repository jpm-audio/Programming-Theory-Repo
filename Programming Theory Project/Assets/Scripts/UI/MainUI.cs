using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MainUI : MonoBehaviour
{
    public Button GoButton;
    public TMP_InputField UserNameText;
    // Start is called before the first frame update
    void Start()
    {
        _SetUserNameIntoInput();
        _UpdateButtonsState();
    }

    private void _UpdateButtonsState()
    {
        GoButton.interactable = UserNameText.text != "";
    }

    private void _SetUserNameIntoInput()
    {
        UserNameText.text = MainManager.Instance.UserName;
    }

    private void _UpdateUserNameFromInput()
    {
        MainManager.Instance.UserName = UserNameText.text;
    }

    public void checkUserName()
    {
        _UpdateButtonsState();
        _UpdateUserNameFromInput();
    }

    public void OnGoPress()
    {
        SceneManager.LoadScene(1);
    }
    
}
