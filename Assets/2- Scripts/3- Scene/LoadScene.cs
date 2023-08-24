using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    
    PlayerLifeAndGold pItens;
    GameMaster gameMaster;


    public void Start()
    {
        pItens = GameObject.Find("Body").GetComponentInChildren<PlayerLifeAndGold>();
        gameMaster = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    public void Intro()
    {
        MusicManager.mManager.PlaySound(0);
        gameMaster.lastCheckPointPos.y = 3;
        gameMaster.lastCheckPointPos.x = -29;
        gameMaster.GoldAtCheckPoint = 0;
        SceneManager.LoadScene("Menu");


    }

    public void MenuScene()
    {
        gameMaster.lastCheckPointPos.y = 3;
        gameMaster.lastCheckPointPos.x = -29;
        gameMaster.GoldAtCheckPoint = 0;
        SceneManager.LoadScene("Menu");
        MusicManager.mManager.PlaySound(1);
        
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        MusicManager.mManager.PlaySound(9);
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
        MusicManager.mManager.PlaySound(1);
    }

    public void SelectLevels()
    {
        SceneManager.LoadScene("SelectLevels");
        MusicManager.mManager.PlaySound(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    //LEVEL COMPLETED/INCOMPLETED OR PAUSE GAME

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }

    public void RestartLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //chama o checkpoint

    }

    public void ExitGame()
    {
        gameMaster.lastCheckPointPos.y = 3;
        gameMaster.lastCheckPointPos.x = -29;
        gameMaster.GoldAtCheckPoint = 0;
        SceneManager.LoadScene("Menu");
        MusicManager.mManager.PlaySound(1);

    }


    //ALL LEVELS

    public void Level01()
    {


        SceneManager.LoadScene("Level-01");
        MusicManager.mManager.PlaySound(2);

    }


}
