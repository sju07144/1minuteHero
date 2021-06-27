using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public static GameManager instance
    {
        get
        {
            if (_instance == null)
            {
                return null;
            }
            return _instance;
        }
    }

    [SerializeField]
    private Timer timerComponent;

    private void Start()
    {
        GameObject timer = GameObject.Find("Timer");
        timerComponent = timer.GetComponent<Timer>();
        timerComponent.gameOver.AddListener(GameOver);
    }

    private void GameOver()
    {
        Debug.Log("GameOver!!");
    }
}
