using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerCore : MonoBehaviour
{
    public GameObject Player;
    public GameObject VFX;
    public GameObject glow;
    public Vector3 vfx = new Vector3((float)54.87, (float)44.09, (float)-66.23711);
    public Transform spawnlocation;

    private void Start()
    {
        //VFX.SetActive(false);

    }
    private void OnTriggerStay(Collider other)
    {
        Player.GetComponent<HUD>().PressE.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            spawnlocation = glow.GetComponent<Transform>();
            Instantiate(VFX, spawnlocation);



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
