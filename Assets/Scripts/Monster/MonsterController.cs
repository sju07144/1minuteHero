using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    [SerializeField]
    private bool isDead;

    private void Start()
    {
        isDead = false;
    }

    public void Die()
    {
        gameObject.SetActive(false);
        isDead = true;
    }
}
