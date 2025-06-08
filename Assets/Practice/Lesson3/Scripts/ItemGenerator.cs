using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _startPosition;
    [SerializeField] private Transform _goalPosition;
    [SerializeField] private float _generatePosY;
    [SerializeField] private int _generateInterval;

    private void Start()
    {
        GeneratePrefab();
    }

    private void GeneratePrefab()
    {
        Vector3 currentPos = _startPosition.position;
        currentPos.y = _generatePosY;
        currentPos.z += _generateInterval;
        
        while (currentPos.z < _goalPosition.position.z)
        {
            Instantiate(_prefab, currentPos, Quaternion.identity, this.gameObject.transform);
            currentPos.z += _generateInterval;
        }
    }
}
