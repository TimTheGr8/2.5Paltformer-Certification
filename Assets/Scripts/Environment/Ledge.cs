using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ledge : MonoBehaviour
{
    [SerializeField]
    private Vector3 _handPosition;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "LedgeChecker")
        {
            Player player = other.GetComponentInParent<Player>();
            if(player != null)
            {
                Debug.Log("Grab Ledge");
                player.GrabLedge(_handPosition);
            }
        }
    }

}
