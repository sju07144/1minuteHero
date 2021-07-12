using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Magic : MonoBehaviour
{
    [SerializeField]
    protected string _magicName;
    [SerializeField]
    protected string magicType;
    [SerializeField]
    protected Sprite magicSprite;
    [SerializeField]
    protected Sprite magicTypeSprite;
    [SerializeField]
    protected GameObject currentMonster;

    protected MonsterController currentMonsterController;

    public string magicName
    {
        get { return _magicName; }
        private set { _magicName = value; }
    }

    public abstract void MagicEnable();
}
