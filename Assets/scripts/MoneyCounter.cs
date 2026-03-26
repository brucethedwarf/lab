using TMPro;
using UnityEngine;

public class MoneyCounter : MonoBehaviour
{
    public static long MoneyCount;
    public TMP_Text moneyDisplay;
    public Data data;

    private void Start()
    {
        MoneyCount = data.money;
    }

    private void Update()
    {
        data.money = MoneyCount;
        moneyDisplay.text = "Money: " + MoneyCount;






    }





}
