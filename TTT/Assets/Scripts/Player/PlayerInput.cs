using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private PlayerShoot playerShoot;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerShoot = GetComponent<PlayerShoot>();
    }

    private void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            playerMovement.PerformUpMovement();
        }
        if (Keyboard.current.sKey.isPressed)
        {
            playerMovement.PerformDownMovement();
        }
        if (Keyboard.current.aKey.isPressed)
        {
            playerMovement.PerformLeftMovement();
        }
        if (Keyboard.current.dKey.isPressed)
        {
            playerMovement.PerformRightMovement();
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            playerShoot.PerformShoot();
        }
    }
}