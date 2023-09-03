using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Awake()
    {
        gameObject.SetActive(false);
        _player.Died += OnDied;
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
    }

    public void Again()
    {
        int gameScene = 0;

        Time.timeScale = 1;
        SceneManager.LoadScene(gameScene);
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void OnDied()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
}
