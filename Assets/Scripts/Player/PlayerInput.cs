using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMover _playerMover;

    private void Start()
    {
        _playerMover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        TryLeftMove();
        TryRightMove();
    }

    private void TryLeftMove()
    {
        if (Input.GetKeyDown(KeyCode.A))
            _playerMover.TryMoveLeft();
    }

    private void TryRightMove()
    {
        if (Input.GetKeyDown(KeyCode.D))
            _playerMover.TryMoveRight();
    }
}
