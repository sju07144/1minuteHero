using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Magic
{
    private void Start()
    {
        _magicName = "FireBall";
        currentMonster = GameObject.Find("Slime");
        currentMonsterController = currentMonster.GetComponent<MonsterController>();
    }

    public override void MagicEnable()
    {
        currentMonsterController.Die();
    }
}
