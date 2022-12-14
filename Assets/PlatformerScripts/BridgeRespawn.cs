using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeRespawn : MonoBehaviour
{
    public Transform teleportTarget; //TeleportPosition
    public GameObject thePlayer; //player ref
    private void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }
}
