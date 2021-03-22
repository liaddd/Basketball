using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Player player;
    public float resetTimer = 5f;

    void Start()
    {
        
    }


    void Update()
    {
        if (!player.holdingBall)
        {
            resetTimer -= Time.deltaTime;
            if(resetTimer <= 0)
            {
                SceneManager.LoadScene("Game");
            }
        }
        
    }
}
