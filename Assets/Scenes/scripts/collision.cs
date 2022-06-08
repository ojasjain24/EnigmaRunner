using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    public cantroller cantroller;
    public AudioSource collisionAudio, winAudio;
    public GameObject explosionEffect;
    public int levelToUnlock;

    void Start(){
        winAudio = GetComponent<AudioSource> ();

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "blocks")
        {
            Instantiate(explosionEffect,  collisionInfo.gameObject.transform.position, collisionInfo.gameObject.transform.rotation);  
            Destroy(collisionInfo.gameObject);
            collisionAudio.Play();
            cantroller.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        if (collisionInfo.collider.tag == "Finish")
        {
            winAudio.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
            FindObjectOfType<GameManager>().WonGame(levelToUnlock);

        }
    }
}
