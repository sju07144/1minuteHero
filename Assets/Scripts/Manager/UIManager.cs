using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;

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

    public static UIManager instance
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
    private Text timeUI;
    [SerializeField]
    private Text magicUI; // 나중에 Image로 변경해야함

    public void UpdateTimeUI(float time)
    {
        timeUI.text = "Time: " + (int)time;
    }

    public void UpdateMagicUI(string magicName)
    {
        magicUI.text = magicName;
    }
}
