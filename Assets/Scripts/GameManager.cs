using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    

    [SerializeField] private GameObject m_GameOverPanel;
    [SerializeField] private AudioSource m_AudioSource;
   
    private void Awake()
    {

        MakeInstance();
    }

    private void MakeInstance()
    {
        if (instance == null)
            instance = this;
    }
    
    public void GameOver()
    {
        m_GameOverPanel.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
        Time.timeScale = 1f;
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void StopMusic()
    {
        m_AudioSource.Stop();
        
    }
    public void PlayMusic()
    {
        m_AudioSource.Play();
    }
    
    

   
}
        

    
   
    
    

        
