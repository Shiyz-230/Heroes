using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private float mx;
    private float my;
    private float MY = 0;
    private float ymin = -40;
    private float ymax = 40;

    void Start()
    {

    }


    void Update()
    {
        _PlayerMove();
    }

    public void _PlayerMove()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * h * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);


        if (Input.GetMouseButton(1))
        {
            mx += Input.GetAxis("Mouse X");
            my += Input.GetAxis("Mouse Y");
            MY = Mathf.Clamp(my, ymin, ymax);
            //transform.eulerAngles = new Vector3(-MY, mx, 0); 
            transform.rotation = Quaternion.AngleAxis(-MY,transform.up)*transform.rotation;

        }
    }
}
