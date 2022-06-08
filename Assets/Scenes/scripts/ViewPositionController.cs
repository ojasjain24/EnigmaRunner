using UnityEngine;
using UnityEngine.UI;  

public class ViewPositionController : MonoBehaviour
{
    public Slider mySlider;  
    public Button viewBtn;
        
    public bool isHorizontal;

    void Start(){
        if(isHorizontal){
            mySlider.value = PlayerPrefs.GetFloat("HPosVB", 1);
        }else{
            mySlider.value = PlayerPrefs.GetFloat("VPosVB", 0);
        }   
    }
    void Update()
    {
        if(isHorizontal){
            viewBtn.transform.position= new Vector3(Screen.width/10+(Screen.width-Screen.width/5)*(mySlider.value),viewBtn.transform.position.y);
            PlayerPrefs.SetFloat("HPosVB", mySlider.value);

        } else{
            viewBtn.transform.position= new Vector3(viewBtn.transform.position.x,Screen.height/10+(Screen.height-Screen.height/5)*(mySlider.value));    
            PlayerPrefs.SetFloat("VPosVB", mySlider.value); 
        }        
    }
}

