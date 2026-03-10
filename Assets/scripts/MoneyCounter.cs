using TMPro;
using UnityEngine;

public class MoneyCounter : MonoBehaviour
{
    public static long  MoneyCount;
    public TMP_Text moneyDisplay;

    private void Update()
    {
        moneyDisplay.text = "Money: " + MoneyCount;

    }





}
