using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
// i hate it here
public class LeavMenu : MonoBehaviour
{
    
    public bool hasloadmenu;
    private Data data;
    public void LoadMenu()

    {
        data.SavePlayer();
        SceneManager.LoadScene("Menu");

    }

    //I HATE CONTOLLER CONTROLS!!!!!!!
    public void OnLoadMenu(InputValue context)
    {
        hasloadmenu = context.isPressed;
        LoadMenu();
    }

    private void Start()
    {
        data = GetComponent<Data>();
        
    }




}
