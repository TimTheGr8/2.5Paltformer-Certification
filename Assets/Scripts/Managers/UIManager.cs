using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("There is no UIManager.");
            
            return _instance;
        }
    }

    [SerializeField]
    private GameObject _interactionText;

    private void Awake()
    {
        _instance = this;
    }

    public void ActivateInteractText(bool isActive)
    {
        _interactionText.SetActive(isActive);
    }
}
