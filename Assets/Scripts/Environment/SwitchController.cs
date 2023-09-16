using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    [SerializeField]
    private Lift _lift;
    [SerializeField]
    private Material _liftActivatedColor;

    private bool _canInteract = false;
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        if (_renderer == null)
            Debug.LogError("The switch does not have a renderer.");
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            UIManager.Instance.ActivateInteractText(true);
            InputManager.Instance.AssignSwitch(this.gameObject);
            _canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            DeactivateSwitch();
        }
    }

    public void ActivateLift()
    {
        if(_canInteract)
        {
            _renderer.material = _liftActivatedColor;
            _lift.Activate();
            BoxCollider col = GetComponent<BoxCollider>();
            Destroy(col);
            DeactivateSwitch();
        }
    }

    private void DeactivateSwitch()
    {
        UIManager.Instance.ActivateInteractText(false);
        InputManager.Instance.AssignSwitch(null);
        _canInteract = false;
    }
}
