using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TaxesTimer : MonoBehaviour
{
    public float countdownTime = 700f;
    public TextMeshProUGUI timerText;
    public bool hasreset;
    private float currentTime;
    public Button timerReset;
    public bool resetTimer;
    public int randomminimumMoneyToResetTimer;

    void Start()
    {
        currentTime = countdownTime;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;

            TimeSpan timeSpan = TimeSpan.FromSeconds(currentTime);
            timerText.text = timeSpan.ToString(@"mm\:ss");
        }
        else
        {
            currentTime = 0;
            timerText.text = "00:00";
            SceneManager.LoadScene("GameOver");
        }
    }





    public void BuyResetTimer()
    {


        randomminimumMoneyToResetTimer = UnityEngine.Random.Range(1, 999999999);

        if (MoneyCounter.MoneyCount >= randomminimumMoneyToResetTimer)
        {
            MoneyCounter.MoneyCount -= randomminimumMoneyToResetTimer;
            hasreset = true;
            currentTime = countdownTime;
        }

    }

    public void OnResetTimer(InputValue context)
    {
        hasreset = context.isPressed;
        BuyResetTimer();
    }


    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }






}

