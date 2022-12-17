using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestInteraction : MonoBehaviour
{
    public GameObject Player;


    private void OnTriggerStay(Collider other)
    {
        Player.GetComponent<HUD>().PressE.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Player.GetComponent<HUD>().dialouge.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Player.GetComponent<HUD>().dialouge.gameObject.SetActive(false);
        Player.GetComponent<HUD>().PressE.gameObject.SetActive(false);
    }
}
