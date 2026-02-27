using UnityEngine;
using UnityEngine.InputSystem;

public class Panel : MonoBehaviour
{
    public bool hastogglepanel;

    public GameObject panel;

    public void TogglePanel()
    {
        panel.SetActive(!panel.activeSelf);
    }


    public void OnBetterJobs(InputValue context)
    {
        hastogglepanel = context.isPressed;
        TogglePanel();
    }



}
