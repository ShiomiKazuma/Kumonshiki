using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    bool isStop = false;
    [SerializeField] float _speed;
    [SerializeField] Transform _goalPosition;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //TODO
        //移動せよ
        //https://candle-stoplight-544.notion.site/4e021f226d584730b715626436ccc330
        if (!isStop)
        {
            _rigidBody.velocity = new Vector3(0, 0, _speed);
        }
        else
        {
            _rigidBody.velocity = new Vector3(0, 0, 0);
        }


        if (_goalPosition.transform.position.z <= transform.position.z)
        {
            isStop = true;
        }
    }
}