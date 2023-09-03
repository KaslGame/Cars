using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public event UnityAction<int> HealthChange;
    public event UnityAction Died;
    
    [SerializeField] private int _maxHealth = 5;

    private int _health;
    private int _minHealth = 0;

    private void Start()
    {
        _health = _maxHealth;
        HealthChange?.Invoke(_health);
    }

    public void AddHealth(int health)
    {
        _health += health;

        if (_health > _maxHealth)
            _maxHealth = _health;

        HealthChange?.Invoke(_health);
    }

    public void TakeDamage(int damage)
    {
        _health = Mathf.Clamp(_health - damage, _minHealth, _maxHealth);
        HealthChange?.Invoke(_health);

        if (_health <= _minHealth)
            Die();
    }

    private void Die()
    {
        Died?.Invoke();
    }
}
