using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MovingBox : MonoBehaviour
{
    [SerializeField] private List<Transform> _points;

    private Queue<Vector3> _pointsPosition;
    private Vector3 _targetPosition;

    private void Awake()
    {
        _pointsPosition = new Queue<Vector3>(_points.Select(point => point.position));

        SwitchTarget();
    }

    private void Update()
    {
        Vector3 direction = _targetPosition - transform.position;

            if (direction.magnitude < 0.05f)
            SwitchTarget();

        transform.Translate(direction.normalized * 5 * Time.deltaTime, Space.World);
    }

    private void SwitchTarget()
    {
        _targetPosition = _pointsPosition.Dequeue();
        _pointsPosition.Enqueue(_targetPosition);
    }
}
