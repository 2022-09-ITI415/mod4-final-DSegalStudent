using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HUD : MonoBehaviour
{
    [Header("Set in Inspector")]
    public Text Collected;
    public GameObject Keycard;

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
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Keycard"))
        {
            CollectedKeycards++;
            Destroy(other.gameObject);
        }
    }
}
