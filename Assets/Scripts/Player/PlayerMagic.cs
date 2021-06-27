using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagic : MonoBehaviour
{
    [SerializeField]
    private PlayerInput playerInput;

    [SerializeField]
    private Magic currentMagic;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    private void SetMagic()
    {
        currentMagic = MagicManager.instance.GetMagicFromInputData(playerInput.currentInputData);
        if (currentMagic == null)
        {
            return;
        }
        UIManager.instance.UpdateMagicUI(currentMagic.magicName);
    }

    private void Update()
    {
        SetMagic();
    }
}
