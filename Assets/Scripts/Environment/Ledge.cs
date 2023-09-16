using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ledge : MonoBehaviour
{
    [SerializeField]
    private Transform _handPosition;
    [SerializeField]
    private Transform _standPosition;
    [SerializeField]
    private bool _ladderEdge = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "LedgeChecker")
        {
            Player player = other.GetComponentInParent<Player>();
            if(player != null)
            {
                if (_ladderEdge)
                    player.LadderInteraction();

                player.GrabLedge(_handPosition.position, this);
            }
        }
    }

    public Vector3 GetStandPos()
    {
        return _standPosition.position;
    }
}