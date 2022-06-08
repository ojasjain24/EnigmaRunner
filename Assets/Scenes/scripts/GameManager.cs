using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public score scoretxt;

    void Start(){
        Time.timeScale = 1;
    }

    public void EndGame() {
        scoretxt.GameOver();
        Invoke("Restart", 1.5f);
    }
    
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
        print("PLAY PRESSED SUCCESSFULLY");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void WonGame(int levelToUnlock){
        print("WON THE GAME");
        if(PlayerPrefs.GetInt("currentLevel",1)<levelToUnlock){
            PlayerPrefs.SetInt("currentLevel", levelToUnlock-1);
        }
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
    }

    public void PauseGame(){
        Time.timeScale = 0;
    }

    public void ResumeGame(){
        Time.timeScale = 1;
    }

    public void JumpToScene(int scene){
         SceneManager.LoadScene(scene);
    }

}
