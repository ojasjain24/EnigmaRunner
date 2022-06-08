using UnityEngine;
using UnityEngine.UI;  

public class joyStickPositionController : MonoBehaviour
{
    public Slider mySlider;  
    public Joystick joystick;
        
    public bool isHorizontal;

    void Start(){
        if(isHorizontal){
            mySlider.value = PlayerPrefs.GetFloat("HPos", 0);
        }else{
            mySlider.value = PlayerPrefs.GetFloat("VPos", 0);
        }   
    }
    void Update()
    {
        if(isHorizontal){
            joystick.transform.position= new Vector3(Screen.width/10+(Screen.width-Screen.width/5)*(mySlider.value),joystick.transform.position.y);
            PlayerPrefs.SetFloat("HPos", mySlider.value);

        } else{
            joystick.transform.position= new Vector3(joystick.transform.position.x,Screen.height/10+(Screen.height-Screen.height/5)*(mySlider.value));    
            PlayerPrefs.SetFloat("VPos", mySlider.value); 
        }        
    }
}
