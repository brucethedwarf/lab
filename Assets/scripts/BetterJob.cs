using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class BetterJob : MonoBehaviour
{

    private PayCheck paycheck;
    public int minimumMoneyToUnlockUpgrade;
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI priceText2;
    public TextMeshProUGUI priceText3;
    public bool hasUpgrade1;
    public bool hasUpgrade2;
    public bool hasUpgrade3;
    public int avarageBonusMoney;
    public Button betterJob1;
    public bool hasbetterjobbutton;
    public Button betterJob2;
    public Button betterJob3;
    public int avarageBonusMoney2;
    public int avarageBonusMoney3;
    public int minimumMoneyToUnlockUpgrade2;
    public int minimumMoneyToUnlockUpgrade3;
    public bool hasbetterjobbutton2;
    public bool hasbetterjobbutton3;
    public Data data;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hasUpgrade1 = (data.betterJob1 == 0) ? false:true ;
        hasUpgrade2 = (data.betterJob2 == 0) ? false:true ;
        hasUpgrade3 = (data.betterJob3 == 0) ? false:true ;

        if (hasUpgrade1)
        {
            betterJob1.interactable = false;
            hasbetterjobbutton = false;
        }

        if (hasUpgrade2)
        {
            betterJob2.interactable = false;
            hasbetterjobbutton2 = false;
        }
        if (hasUpgrade3)
        {
            betterJob3.interactable = false;
            hasbetterjobbutton3 = false;
        }
        paycheck = PayCheck.instance;
        UpdateText();

    }


    public void BuyUpgrade()
    {
        if (MoneyCounter.MoneyCount >= minimumMoneyToUnlockUpgrade)
        {
            MoneyCounter.MoneyCount -= minimumMoneyToUnlockUpgrade;

            hasUpgrade1 = true;
            betterJob1.interactable = false;
            hasbetterjobbutton = false;
            data.betterJob1 = 1;

        }

    }




    private void UpdateText()
    {
        priceText.text = "Need " + minimumMoneyToUnlockUpgrade.ToString() + " Money";
        priceText2.text = "Need " + minimumMoneyToUnlockUpgrade2.ToString() + " Money";
        priceText3.text = "Need " + minimumMoneyToUnlockUpgrade3.ToString() + " Money";
    }




    public void OnBetterJobButton(InputValue context)
    {
        hasbetterjobbutton = context.isPressed;
        BuyUpgrade();
    }

    public void BuyUpgrade2()
    {
        if (MoneyCounter.MoneyCount >= minimumMoneyToUnlockUpgrade2)
        {
            MoneyCounter.MoneyCount -= minimumMoneyToUnlockUpgrade2;

            hasUpgrade2 = true;
            betterJob2.interactable = false;
            hasbetterjobbutton2 = false;
            data.betterJob2 = 1;
        }

    }
    public void OnBetterJobButton2(InputValue context)
    {
        hasbetterjobbutton2 = context.isPressed;
        BuyUpgrade2();
    }



    public void BuyUpgrade3()
    {
        if (MoneyCounter.MoneyCount >= minimumMoneyToUnlockUpgrade3)
        {
            MoneyCounter.MoneyCount -= minimumMoneyToUnlockUpgrade3;

            hasUpgrade3 = true;
            betterJob3.interactable = false;
            hasbetterjobbutton3 = false;
            data.betterJob3 = 1;
        }

    }
    public void OnBetterJobButton3(InputValue context)
    {
        hasbetterjobbutton3 = context.isPressed;
        BuyUpgrade3();
    }


















}

