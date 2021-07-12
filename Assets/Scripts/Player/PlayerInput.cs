using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public struct InputData
{
    public int firstClick;
    public int secondClick;

    public InputData(int first, int second)
    {
        firstClick = first;
        secondClick = second;
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

    private bool _isClickedT;
    public bool isClickedT { get; private set; }

    private void Start()
    {
        _currentInputData = new InputData(-1, -1);
        isClickedT = false;
    }

    private void Update()
    {
        SetInput();
        Initialize();
        ClickT();
        if (Input.anyKeyDown)
            ForDebugging();
    }

    public void SetInput()
    {
        if (_currentInputData.firstClick == -1)
        {
            if (Input.GetKeyDown(KeyCode.E))
                _currentInputData.firstClick = 0;
            else if (Input.GetKeyDown(KeyCode.R))
                _currentInputData.firstClick = 1;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
                _currentInputData.secondClick = 0;
            else if (Input.GetKeyDown(KeyCode.R))
                _currentInputData.secondClick = 1;
        }
    }

    public void Initialize()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _currentInputData.firstClick = -1;
            _currentInputData.secondClick = -1;
            UIManager.instance.UpdateMagicUI("Null"); // 변경해야함. 이렇게 하는게 아닌 것 같음.
        }
    }

    public void ClickT()
    {
        isClickedT = Input.GetKeyDown(KeyCode.T);
    }

    private void ForDebugging()
    {
        Debug.Log("First Click: " + _currentInputData.firstClick);
        Debug.Log("Second Click: " + _currentInputData.secondClick);
    }
}

