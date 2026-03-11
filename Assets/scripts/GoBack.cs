using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class GoBack : MonoBehaviour
{
    public bool hasloadmenu;

    public void LoadMenu()

    {

        SceneManager.LoadScene("Menu");

    }

    //I HATE CONTOLLER CONTROLS!!!!!!!
    public void OnLoadMenu(InputValue context)
    {
        hasloadmenu = context.isPressed;
        LoadMenu();
    }






}
