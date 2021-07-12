using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public struct InputDataTemporary
{
    public int[] inputArray;

    public InputDataTemporary(int first, int second)
    {
        inputArray = new int[2];
        this.inputArray[0] = first;
        this.inputArray[1] = second;
    }
}

public class PlayerInputTemporary : MonoBehaviour
{
    [SerializeField]
    private InputDataTemporary _currentInputData;

    public InputDataTemporary currentInputData
    {
        get { return _currentInputData; }
        private set { _currentInputData = value; }
    }

    private void Start()
    {
        _currentInputData = new InputDataTemporary(-1, -1);
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
        if (_currentInputData.inputArray[0] == -1)
        {
            if (Input.GetKeyDown(KeyCode.E))
                _currentInputData.inputArray[0] = 0;
            else if (Input.GetKeyDown(KeyCode.R))
                _currentInputData.inputArray[0] = 1;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
                _currentInputData.inputArray[1] = 0;
            else if (Input.GetKeyDown(KeyCode.R))
                _currentInputData.inputArray[1] = 1;
        }
    }

    public void Initialize()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _currentInputData.inputArray[0] = -1;
            _currentInputData.inputArray[1] = -1;
            UIManager.instance.UpdateMagicUI("Null"); // 변경해야함. 이렇게 하는게 아닌 것 같음.
        }
    }

    public void ClickT()
    {
        // 마법 발동 코드 입력
    }

    private void ForDebugging()
    {
        Debug.Log("First Click: " + _currentInputData.inputArray[0]);
        Debug.Log("Second Click: " + _currentInputData.inputArray[1]);
    }
}
