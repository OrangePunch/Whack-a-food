using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    private float time = 60;
    private GameManagerX gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
    }

    void Update()
    {
        if (gameManager.isGameActive)
        {
            UpdateTime();
        }
    }

    public void UpdateTime()
    {
        if (time > 0)
        {
            timeText.text = "Time: " + time;
            time -= Time.deltaTime;
        }
        else if (time <= 0)
        {
            gameManager.isGameActive = false;
        }
    }
}
