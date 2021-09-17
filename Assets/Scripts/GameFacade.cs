using System;
using UnityEngine;


public class GameFacade : MonoBehaviour
{
    [SerializeField] private LevelPopulator levelPopulator;

    public void PopulateLevel()
    {
        levelPopulator.CreateAsteroids();
        levelPopulator.CreateEnemyShip();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        Application.Quit();
    }
}