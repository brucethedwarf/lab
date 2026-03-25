using UnityEngine;

public class Data : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int BetterJob1 = 1;
    public int betterjob2 = 2;
    public int betterjob3 = 3;



    public class PlayerData
    {
        public int betterjob1;
        public int betterjob2;
        public int betterjob3;
        
        public int money;

    }

    public Data(Data data)
    {
        BetterJob1 = data.BetterJob1;
        betterjob2 = data.betterjob2; 
        betterjob3 = data.betterjob3;
    }

}
