using UnityEngine;
using UnityEngine.SceneManagement;

public class TrainingCollision : MonoBehaviour
{
    public cantroller cantroller;
    public AudioSource collisionAudio, winAudio;
    public GameObject explosionEffect;

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
        }
        if (collisionInfo.collider.tag == "Finish")
        {
            winAudio.Play();
        }
    }
}
