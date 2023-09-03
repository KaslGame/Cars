using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    [SerializeField] private int _amountHealh;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
            player.AddHealth(_amountHealh);

        Die();
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
