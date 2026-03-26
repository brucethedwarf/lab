using System;
using UnityEngine;

using System;
using UnityEngine;

public class Data : MonoBehaviour
{
    public int betterJob1 = 0;
    public int betterJob2 = 0;
    public int betterJob3 = 0;
    public long money;
    
    private void Awake()
    {
        LoadPlayer();
    }

    public void savePlayer ()
    {
        SaveData.SavePlayer(this);
    }

    public void LoadPlayer ()
    {
        PlayerData data = SaveData.LoadPlayer();

        betterJob1 = data.betterJob1;
        betterJob2 = data.betterJob2;
        betterJob3 = data.betterJob3;
        money = data.money;

        


    }
}

[Serializable]
public class PlayerData
{
    public int betterJob1;
    public int betterJob2;
    public int betterJob3;
    public long money;

    public PlayerData(Data data)
    {
        betterJob1 = data.betterJob1;
        betterJob2 = data.betterJob2;
        betterJob3 = data.betterJob3;
        money = data.money;
    }
   
}
