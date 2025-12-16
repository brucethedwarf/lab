using UnityEngine;
using TMPro;

public class MoneyCounter : MonoBehaviour
{
    public static int MoneyCount;
    public TMP_Text moneyDisplay;
    
    private void Update()
    {
        moneyDisplay.text = "Money: " + MoneyCount;
        
    }
}
