using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class GameOverMenu : MonoBehaviour
{
    public void ContinueWithAd()
    {
        AdManager.instance.PlayRevardedAd();
        GameManager.instance.HealAllServers();
    }
    public void RetryBtn()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitToMainMenuBtn()
    {
        SceneManager.LoadScene(0);
    }
}
