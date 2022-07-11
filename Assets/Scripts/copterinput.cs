using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copterinput : MonoBehaviour
{
        public float X { get; private set; }
        public float Y { get; private set; }

    public bool FRONT { get; private set; }
    public bool BACK { get; private set; }
    public bool LEFT { get; private set; }
    public bool RIGHT { get; private set; }

    public  bool Engine { get; private set; }

    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        Engine = false;
    }

    // Update is called once per frame
    void Update()
    {
        X = Y = 0f;
        X = Input.GetAxis("Horizontal");
        Y = Input.GetAxis("Vertical");

        FRONT = Input.GetKey(KeyCode.I);
        BACK = Input.GetKey(KeyCode.K);
        LEFT = Input.GetKey(KeyCode.J);
        RIGHT = Input.GetKey(KeyCode.L);


        Engine = Input.GetKeyDown(KeyCode.R);

    }
}
