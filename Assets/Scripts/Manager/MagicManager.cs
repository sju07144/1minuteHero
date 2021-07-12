using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicManager : MonoBehaviour
{
    private static MagicManager _instance;

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

    public static MagicManager instance
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
    private Dictionary<InputData, Magic> magicStorage;

    private void Start()
    {
        magicStorage = new Dictionary<InputData, Magic>();
        InitializeStorage();
    }

    private void InitializeStorage()
    {
        magicStorage.Add(new InputData(0, 0), this.gameObject.AddComponent<FireBall>()); // new keyword�� ������� ����.(MonoBehavior����), AddComponent ���
    }

    public Magic GetMagicFromInputData(InputData input)
    {
        Magic value;
        if (magicStorage.TryGetValue(input, out value))
        {
            return value;
        }
        return null;
    }
}
