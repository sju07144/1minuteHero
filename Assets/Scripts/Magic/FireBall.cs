using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : Magic, IDamageable
{
    [SerializeField]
    private int damage;
    public void Damage()
    {
        // monster.Damage(damage);
    }

    private void Start()
    {
        damage = 40;
        _magicName = "FireBall";
    }

    public override void MagicEnable()
    {
        Damage();
    }
}
