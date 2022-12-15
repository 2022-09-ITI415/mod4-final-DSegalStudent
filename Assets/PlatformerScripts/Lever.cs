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


    private void Start()
    {
        Door1.GetComponent<Animator>().enabled = false;
        Door2.GetComponent<Animator>().enabled = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E) && Player.GetComponent<HUD>().CollectedKeycards >= 5)
        {
            doorOpen = true;
            Debug.Log("Door Open");
            Door1.GetComponent<Animator>().enabled = true;
            Door1.GetComponent<Animator>().Play("Front Gate Opening");
            Door2.GetComponent<Animator>().enabled = true;
            Door2.GetComponent<Animator>().Play("Front Gate Opening");


            //StartCoroutine("CloseDoor");
        }else if (Player.GetComponent<HUD>().CollectedKeycards < 5)
        {
            Player.GetComponent<HUD>().LeverErrorPrompt.gameObject.SetActive(true);
            StartCoroutine("DisableErrorText");
        }
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
        //Door1.GetComponent<Animator>().StopPlayback();
        //doorOpen = false;
        //Debug.Log("Door Closed");
    }
}
