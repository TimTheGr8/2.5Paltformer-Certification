using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ledge : MonoBehaviour
{
    [SerializeField]
    private Vector3 _handPosition;
    [SerializeField]
    private Vector3 _standPos;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "LedgeChecker")
        {
            Player player = other.GetComponentInParent<Player>();
            if(player != null)
            {
                player.GrabLedge(_handPosition, this);
            }
        }
    }

    public Vector3 GetStandPos()
    {
        return _standPos;
    }
}