using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.HealthChange += OnHealthChange;
    }

    private void OnDisable()
    {
        _player.HealthChange -= OnHealthChange;
    }

    private void OnHealthChange(int health)
    {
        _text.text = health.ToString();
    }
}
