using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HUD : MonoBehaviour
{
    [Header("Set in Inspector")]
    public Text Collected;
    public Text LeverErrorPrompt;
    public Text PressE;
    public Text Victory;
    public GameObject Keycard;
    public AudioSource audioSource;
    public AudioClip audioclip;
    public AudioClip DoorOpening;
    public AudioClip PowerCore;

    [Header("Set Dynamically")]
    public int CollectedKeycards;
 
    

public void UpdateHUD()
    {
        
        Collected.text = "Keycards Collected: " + CollectedKeycards + " Out of 5";
    }
    public void Update()
    {
        UpdateHUD();
    }
    public void Start()
    {
        UpdateHUD();
        LeverErrorPrompt.gameObject.SetActive(false);
        PressE.gameObject.SetActive(false);
        Victory.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Keycard"))
        {
            CollectedKeycards++;
            audioSource.PlayOneShot(audioclip);
            Destroy(other.gameObject);

        }
    }

    public void PlayDoorOpening()
    {
        audioSource.PlayOneShot(DoorOpening);
    }

    public void PlayPowerCore()
    {
        audioSource.PlayOneShot(PowerCore);
    }

}
