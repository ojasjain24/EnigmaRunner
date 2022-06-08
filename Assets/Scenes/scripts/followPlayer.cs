using UnityEngine;
using UnityEngine.UI;  

public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Button viewBtn;
    void Start()
    {
        viewBtn.transform.position= new Vector3(120+(Screen.width-240)*PlayerPrefs.GetFloat("HPosVB", 0),120+(Screen.height-240)*PlayerPrefs.GetFloat("VPosVB", 0));
    }    
    void Update()
    {
        Vector3 offset = new Vector3( PlayerPrefs.GetInt("offSetX", 0),PlayerPrefs.GetInt("offSetY", 2),PlayerPrefs.GetInt("offSetZ", -5));
        transform.position = player.position+ offset;
    }
    public void onPress(){
        if(PlayerPrefs.GetInt("offSetZ", 0)==0){
        PlayerPrefs.SetInt("offSetX", 0);
        PlayerPrefs.SetInt("offSetY", 2);
        PlayerPrefs.SetInt("offSetZ", -5);
        }else{
        PlayerPrefs.SetInt("offSetX", 0);
        PlayerPrefs.SetInt("offSetY", 1);
        PlayerPrefs.SetInt("offSetZ", 0);
            }
    }
}
