using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2.5f;
    [SerializeField]
    private int _floorCount = 2;
    [SerializeField]
    private List<Transform> _floorHeight = new List<Transform>();
    [SerializeField]
    private float _waitTimeOnFloor = 5.0f;

    private Transform _currentTarget;
    [SerializeField]
    private int _currentIndex = 0;
    private bool _waiting = false;
    private bool _active = false;
    private bool _movingDown = true;
    private Coroutine _move;

    private void Start()
    {
        _currentTarget = _floorHeight[0];
    }

    private void FixedUpdate()
    {
        if (_active)
        {
            var step = _speed * Time.deltaTime;
            this.transform.position = Vector3.MoveTowards(this.transform.position, _currentTarget.transform.position, step);
            if (Vector3.Distance(this.transform.position, _currentTarget.transform.position) <= 0.1f && !_waiting)
            {
                _waiting = true;
                _move = StartCoroutine(Move());
            }
        }
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

    private void ChangeDestination()
    {
        if (_movingDown)
        {
            _currentIndex++;
            if (_currentIndex >= _floorHeight.Count)
            {
                _currentIndex--;
                _movingDown = !_movingDown;
            }
        }
        if (!_movingDown)
        {
            _currentIndex--;
            if (_currentIndex <= 0)
            {
                _movingDown = !_movingDown;
            }
        }
        _currentTarget = _floorHeight[_currentIndex];
    }

    public void Activate()
    {
        ChangeDestination();
        _active = true;
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(_waitTimeOnFloor);
        ChangeDestination();
        _waiting = false;
        StopCoroutine(_move);
    }
}
