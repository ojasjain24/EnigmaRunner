using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelSelector : MonoBehaviour
{
    public Button[] levelButtons; 
    void Start(){

        int levelReached = PlayerPrefs.GetInt("levelReached",2);
        for (int i = 2; i < levelButtons.Length+2; i++)
        {
            if(i > levelReached){
                levelButtons[i-2].interactable = false;
            }
        }
    }


    public void selectLevel(int levelNumber){
        SceneManager.LoadScene(levelNumber);
    }
}
