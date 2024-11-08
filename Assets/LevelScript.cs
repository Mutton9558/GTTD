using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelScript : MonoBehaviour
{
    public Button[] buttons;

    private void Awake()
    {
        int unlockedLevel = Mathf.Max(PlayerPrefs.GetInt("UnlockedLevel", 2), 2);
        for (int i=0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i=0; i < unlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void OpenLevel(int levelID)
    {
        string levelName = "Level " + levelID;
        if (levelName == "Level 0")
        {
            SceneManager.LoadScene("Tutorial");
        }
        else
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
