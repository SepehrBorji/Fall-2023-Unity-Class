using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    [System.Serializable]
    class SaveData
    {
        public Color TeamColor;
    }

    public static MainManager Instance { get; private set; }

    public Color TeamColor;

    public void SaveColor()
    {
        SaveData colorData = new SaveData();
        colorData.TeamColor = TeamColor;

        string json = JsonUtility.ToJson(colorData);
        Debug.Log("Data written: " + json);

        File.WriteAllText(Application.persistentDataPath + "/colorSaveData.json", json);
    }

    public void LoadColor()
    {
        string filePath = Application.persistentDataPath + "/colorSaveData.json";

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);

            Debug.Log("Data read: " + json);

            SaveData colorData = JsonUtility.FromJson<SaveData>(json);
            TeamColor = colorData.TeamColor;
        }
    }

    void Awake()
    {
        // make singleton
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        // make sure data persists
        DontDestroyOnLoad(gameObject);

        LoadColor();
    }

}



