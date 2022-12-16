using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCore : MonoBehaviour
{
    public GameObject Player;
    public GameObject VFX;

    private void Start()
    {
        VFX.SetActive(false);
    }
    private void OnTriggerStay(Collider other)
    {
        Player.GetComponent<HUD>().PressE.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            VFX.SetActive(true);
            Player.GetComponent<HUD>().PlayPowerCore();
            Time.timeScale = 0;
            Player.GetComponent<HUD>().Victory.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Player.GetComponent<HUD>().PressE.gameObject.SetActive(false);
    }
}
