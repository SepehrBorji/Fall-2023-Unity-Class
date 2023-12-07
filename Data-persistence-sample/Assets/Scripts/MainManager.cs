using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public Color TeamColor;

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
    }

}

[System.Serializable]
class SaveData
{
    public Color TeamColor;
}

