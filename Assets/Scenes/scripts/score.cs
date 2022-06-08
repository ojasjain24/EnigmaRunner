using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoretxt;
    public int levelNumber;
    private bool isGameOver = false;
    public bool isHighScoreText;

    void Start(){

        if(PlayerPrefs.GetInt("levelReached", 2)>=3){
            PlayerPrefs.SetFloat("Level 1 Score",100);
        }
        if(PlayerPrefs.GetInt("levelReached", 2)>=4){
        PlayerPrefs.SetFloat("Level 2 Score",100);
        }
        if(PlayerPrefs.GetInt("levelReached", 2)>=5){
            PlayerPrefs.SetFloat("Level 3 Score",100);
        }
        if(PlayerPrefs.GetInt("levelReached", 2)>=6){
            PlayerPrefs.SetFloat("Level 4 Score",100);
        }
        if(PlayerPrefs.GetInt("levelReached", 2)>=7){
            PlayerPrefs.SetFloat("Level 5 Score",100);
        }
    }
    void Update()
    {
        if(isHighScoreText){
            scoretxt.text = "High Score : " + (PlayerPrefs.GetFloat("Level 1 Score") +PlayerPrefs.GetFloat("Level 2 Score") +PlayerPrefs.GetFloat("Level 3 Score") +PlayerPrefs.GetFloat("Level 4 Score") +PlayerPrefs.GetFloat("Level 5 Score")).ToString("0");
        }else{
             if(!isGameOver){
                scoretxt.text = (player.position.z+45).ToString("0");
                if(levelNumber == 1 && (PlayerPrefs.GetFloat("Level 1 Score",0)<(player.position.z+45))){
                    PlayerPrefs.SetFloat("Level 1 Score",(player.position.z+45));
                }   
                if(levelNumber == 2 && (PlayerPrefs.GetFloat("Level 2 Score",0)<(player.position.z+45))){
                    PlayerPrefs.SetFloat("Level 2 Score",(player.position.z+45));
                }   
                if(levelNumber == 3 && (PlayerPrefs.GetFloat("Level 3 Score",0)<(player.position.z+45))){
                    PlayerPrefs.SetFloat("Level 3 Score",(player.position.z+45));
                }   
                if(levelNumber == 4 && (PlayerPrefs.GetFloat("Level 4 Score",0)<(player.position.z+45))){
                    PlayerPrefs.SetFloat("Level 4 Score",(player.position.z+45));
                }
                if(levelNumber == 5 && (PlayerPrefs.GetFloat("Level 5 Score",0)<(player.position.z+45))){
                    PlayerPrefs.SetFloat("Level 5 Score",(player.position.z+45));
                }
            }
        }
    }
    public void GameOver() {
        isGameOver = true;
        scoretxt.text = "Game Over";
    }
}
