using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public static class SaveData
{
    public static void SavePlayer(Data source)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = UnityEngine.Application.persistentDataPath + "/player.fun";

        using (FileStream stream = new FileStream(path, FileMode.Create))
        {
            PlayerData data = new PlayerData(source);
            formatter.Serialize(stream, data);
            stream.Close();
            
        }
    }

    public static PlayerData LoadPlayer()
    {
        string path = UnityEngine.Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);    

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
        } else
        {
            Debug.LogError("Save file not found in" +  path);
            return null;
        }
    }
}