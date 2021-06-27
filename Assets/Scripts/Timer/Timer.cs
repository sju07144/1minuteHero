using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float remainTime;

    private bool isTimeZero; // 남은 시간이 0초인지 검사. 0초이면 gameover 이벤트 호출

    public UnityEvent gameOver;
    // Start is called before the first frame update
    void Start()
    {
        // remainTime = 60.0f;
        isTimeZero = false;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
    }

    void UpdateTime()
    {
        if (remainTime > 0.0f)
        {
            remainTime -= Time.deltaTime;
            UIManager.instance.UpdateTimeUI(remainTime);
        }

        if (remainTime <= 0.0f && !isTimeZero)
        {
            isTimeZero = true; // 어디서 false 해야하는지 결정해야함
            gameOver.Invoke();
        }
    }
}
