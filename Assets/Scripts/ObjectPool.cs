using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    [SerializeField] private int _capacity;
    [SerializeField] private GameObject _singlePrefab;

    private List<GameObject> _pool = new List<GameObject>();

    protected void Initialize(GameObject prefab)
    {
        for (int i = 0; i < _capacity; i++)
        {
            GameObject spawned = Instantiate(prefab, _container.transform);
            spawned.gameObject.SetActive(false);

            _pool.Add(spawned);
        }

        if (_singlePrefab != null)
        {
            GameObject heart = Instantiate(_singlePrefab, _container.transform);
            heart.gameObject.SetActive(false);
            _pool.Add(heart);
        }
    }

    protected void Initialize(GameObject[] prefab)
    {
        for (int i = 0; i < _capacity; i++)
        { 
            int randomIndex = Random.Range(0, prefab.Length);

            GameObject spawned = Instantiate(prefab[randomIndex], _container.transform);
            spawned.gameObject.SetActive(false);

            _pool.Add(spawned);
        }

        if (_singlePrefab != null)
        {
            GameObject heart = Instantiate(_singlePrefab, _container.transform);
            heart.gameObject.SetActive(false);
            _pool.Add(heart);
        }
    }

    protected bool TryGetObject(out GameObject result)
    {
        result = _pool.FirstOrDefault(p => p.gameObject.activeSelf == false);

        return result != null;
    }
}
