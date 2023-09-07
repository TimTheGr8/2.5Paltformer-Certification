using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField]
    private int _scoreAmount = 1;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();
            if(player != null)
            {
                player.AdjustScore(_scoreAmount);
                Destroy(this.gameObject);
            }    
        }
    }
}
