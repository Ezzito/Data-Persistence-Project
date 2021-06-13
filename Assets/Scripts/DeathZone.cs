using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public MainManager Manager;

    private void OnCollisionEnter(Collision other)
    {
        
        Destroy(other.gameObject);
        Manager.GameOver();
        //Debug.Log("Name: " + ScoreManager.Instance.playerName);
        //Debug.Log("Score: " + ScoreManager.Instance.highScore);
        ScoreManager.Instance.SaveScore();

    }
}
