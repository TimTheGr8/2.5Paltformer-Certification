using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    private Player _player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _player = other.GetComponent<Player>();
            if(_player != null)
            {
                InputManager.Instance.AsssignLadder(this.gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.parent = null;
            _player = other.GetComponent<Player>();
            if (_player != null)
            {
                InputManager.Instance.AsssignLadder(null);
            }
        }
    }
}
