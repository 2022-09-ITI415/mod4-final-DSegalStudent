using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keycard : MonoBehaviour
{
    public GameObject PlayerRef;
    public AudioSource audioSource;
    public AudioClip audioclip;
    public HUD hud;
    public int totalcards = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 100f * Time.deltaTime, 0f, Space.Self);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(audioclip);
        //totalcards++;
        //hud.CollectedKeycards = totalcards;
        //hud.UpdateHUD();
        Destroy(this.gameObject);
        
        
    }
    //PlayerRef.updateUI()
    */
}
