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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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

        }

    }
    public void OnBetterJobButton3(InputValue context)
    {
        hasbetterjobbutton3 = context.isPressed;
        BuyUpgrade3();
    }


















}

