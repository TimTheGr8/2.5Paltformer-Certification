using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    private Transform _targetA;
    [SerializeField]
    private Transform _targetB;
    [SerializeField]
    private float _speed = 2.5f;

    private Transform _currentTarget;

    private void Start()
    {
        _currentTarget = _targetA;
    }

    private void FixedUpdate()
    {
        var step = _speed * Time.deltaTime;

        this.transform.position = Vector3.MoveTowards(this.transform.position, _currentTarget.transform.position, step);

        if (Vector3.Distance(this.transform.position, _currentTarget.position) < 0.25f)
        {
            ChooseTarget();
        }
    }

    private void ChooseTarget()
    {
        if (_currentTarget == _targetA)
            _currentTarget = _targetB;
        else
            _currentTarget = _targetA;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.parent = this.gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.parent = null;
        }
    }
}
