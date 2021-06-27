using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float remainTime;

    private bool isTimeZero; // ���� �ð��� 0������ �˻�. 0���̸� gameover �̺�Ʈ ȣ��

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
            isTimeZero = true; // ��� false �ؾ��ϴ��� �����ؾ���
            gameOver.Invoke();
        }
    }
}
