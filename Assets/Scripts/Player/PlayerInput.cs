using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public struct InputData
{
    public int qCount;
    public int wCount;
    public int eCount;

    public InputData(int q, int w, int e)
    {
        this.qCount = q;
        this.wCount = w;
        this.eCount = e;
    }
}

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private InputData _currentInputData;

    public InputData currentInputData
    {
        get { return _currentInputData; }
        private set { _currentInputData = value; }
    }

    private void Start()
    {
        _currentInputData = new InputData(0, 0, 0);
    }

    private void Update()
    {
        SetInput();
        Initialize();
        if (Input.anyKeyDown)
            ForDebugging();
    }

    public void SetInput()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            _currentInputData.qCount += 1;
        else if (Input.GetKeyDown(KeyCode.W))
            _currentInputData.wCount += 1;
        else if (Input.GetKeyDown(KeyCode.E))
            _currentInputData.eCount += 1;
    }

    public void Initialize()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _currentInputData.qCount = 0;
            _currentInputData.wCount = 0;
            _currentInputData.eCount = 0;
            UIManager.instance.UpdateMagicUI("Null"); // 변경해야함. 이렇게 하는게 아닌 것 같음.
        }
    }

    public void ClickR()
    {
        // 마법 발동 코드 입력
    }

    private void ForDebugging()
    {
        Debug.Log("QCount: " + _currentInputData.qCount);
        Debug.Log("WCount: " + _currentInputData.wCount);
        Debug.Log("ECount: " + _currentInputData.eCount);
    }
}
