using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject playMenuPanel;
    public GameObject settingsMenuPanel;
    public GameObject authorMenuPanel;
    public string showPanel;
   
    public void ExitPressed()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif

    }


    public void SwitchPanels()
    {
 
           switch(showPanel){   
            case "MainMenu":{
                    playMenuPanel.SetActive(false);
                    settingsMenuPanel.SetActive(false);
                    authorMenuPanel.SetActive(false);
                    mainMenuPanel.SetActive(true);
                    break;
                }
            case "PlayMenu": {
                    playMenuPanel.SetActive(true);
                    settingsMenuPanel.SetActive(false);
                    authorMenuPanel.SetActive(false);
                    mainMenuPanel.SetActive(false);
                    break;
                }
            case "SettingsMenu": {
                    playMenuPanel.SetActive(false);
                    settingsMenuPanel.SetActive(true);
                    authorMenuPanel.SetActive(false);
                    mainMenuPanel.SetActive(false);
                    break;
                }
            case "AuthorMenu": {
                    playMenuPanel.SetActive(false);
                    settingsMenuPanel.SetActive(false);
                    authorMenuPanel.SetActive(true);
                    mainMenuPanel.SetActive(false);
                    break;
                }
            default: {
                    Debug.Log("Такой панели не существует!");
                    break;
                }
        }
 
    }

}

