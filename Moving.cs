using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField]
    private Transform _targetA, _targetB;
    public float _speed = 0.5f;
    private bool _switching = false;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(2, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (_switching == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetB.position, _speed * Time.deltaTime);

        }
        else if (_switching == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetA.position, _speed * Time.deltaTime);
        }
        if (transform.position == _targetB.position)
        {
            _switching = true;
        }
        else if (transform.position == _targetA.position)
        {
            _switching = false;
        }
    }
}
