using UnityEngine;
using UnityEngine.InputSystem;
public class PayCheck : MonoBehaviour
{
    public bool hasclick;
    public static PayCheck instance;
    public float TotalMoney;
    public bool hasUpgrade;
    private BetterJob betterJob;
    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        betterJob = GetComponent<BetterJob>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public GameObject textbox;

    public void ClickTheButton()
    {
        textbox.SetActive(true);
        if (betterJob.hasUpgrade1)
        {
            MoneyCounter.MoneyCount += 49;
        }
        else
        {
            MoneyCounter.MoneyCount += 7;
        }

        if (betterJob.hasUpgrade2)
        {
            MoneyCounter.MoneyCount += 2401;
        }
        else
        {
            MoneyCounter.MoneyCount += 0;
        }

        if (betterJob.hasUpgrade3)
        {
            MoneyCounter.MoneyCount += 5764801;
        }
        else
        {
            MoneyCounter.MoneyCount += 0;
        }






    }


    public void AddMoney()
    {
        TotalMoney++;

    }



    public void OnClick(InputValue context)
    {
        hasclick = context.isPressed;
        ClickTheButton();
    }


    


}


