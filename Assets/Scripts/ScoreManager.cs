using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager Instance;

    public int highScore;
    public int currentScore;

    public string playerName;

    // Start is called before the first frame update
    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void TakePlayerName(string s)
    {
        playerName = s;
        Debug.Log(playerName);
    }

}
