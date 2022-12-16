using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    bool doorOpen = false;
    public float timer;
    public GameObject Door1;
    public GameObject Door2;
    public GameObject Player;
    public GameObject cam;
    public GameObject FPSCam;


    private void Start()
    {
        Door1.GetComponent<Animator>().enabled = false;
        Door2.GetComponent<Animator>().enabled = false;
        cam.GetComponent<Camera>().enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        Player.GetComponent<HUD>().PressE.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E) && Player.GetComponent<HUD>().CollectedKeycards >= 5)
        {
            doorOpen = true;
            Debug.Log("Door Open");
            FPSCam.GetComponent<Camera>().enabled = false;
            cam.GetComponent<Camera>().enabled = true;
            Door1.GetComponent<Animator>().enabled = true;
            Door1.GetComponent<Animator>().Play("Front Gate Opening");
            Door2.GetComponent<Animator>().enabled = true;
            Door2.GetComponent<Animator>().Play("Front Gate Opening");
            Player.GetComponent<HUD>().PlayDoorOpening();


            StartCoroutine("CloseDoor");
        }else if (Player.GetComponent<HUD>().CollectedKeycards < 5)
        {
            Player.GetComponent<HUD>().LeverErrorPrompt.gameObject.SetActive(true);
            StartCoroutine("DisableErrorText");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Player.GetComponent<HUD>().PressE.gameObject.SetActive(false);
    }
    IEnumerator DisableErrorText()
    {
        yield return new WaitForSeconds(timer);
        Player.GetComponent<HUD>().LeverErrorPrompt.gameObject.SetActive(false);
    }
    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(timer);
        Door1.GetComponent<Animator>().enabled = false;
        Door2.GetComponent<Animator>().enabled = false;
        
        FPSCam.GetComponent<Camera>().enabled = true;
        cam.GetComponent<Camera>().enabled = false;
        //Door1.GetComponent<Animator>().StopPlayback();
        //doorOpen = false;
        //Debug.Log("Door Closed");
    }
}
