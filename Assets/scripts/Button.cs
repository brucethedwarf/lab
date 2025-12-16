using Unity.VisualScripting;
using UnityEngine;

public class Button : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject textbox;

    public void ClickTheButton()
    {
        textbox.SetActive(true);
        MoneyCounter.MoneyCount += 7;
       

    }

}
