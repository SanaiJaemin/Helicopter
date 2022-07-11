using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coptermov : MonoBehaviour
{
    public GameObject WIng;
    private copterinput _input;
    private Rigidbody _rigidbody;
    public float _move = 1f;
    private bool swich_on = false;
    public float propspeed = 500f;

    void Awake()
    {
        _input = GetComponent<copterinput>();
        _rigidbody = GetComponent<Rigidbody>();
    }
     void Update()
    {
        float xSpeed = _input.X * _move; 
        float zSpeed = _input.Y * _move;

        if (_input.Engine)
        {
            swich_on = !swich_on;
        }

        if (swich_on)
        {
            WIng.transform.Rotate(0f,propspeed * Time.deltaTime, 0f);
            _rigidbody.AddForce(0f, zSpeed, 0f);
            gameObject.transform.Rotate(0f, xSpeed, 0f);
        }
        else
        {
            _rigidbody.AddForce(0f, -1f, 0f);
        }
    }

}
