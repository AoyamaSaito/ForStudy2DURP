using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ShotMove : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb;
    [SerializeField]
    private float _power = 30;
    [SerializeField]
    private float _torquePower = 30; 

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Move();
        }
    }

    private void Move()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 dir = (transform.position - mousePosition).normalized * _power;
        _rb.AddForce(dir, ForceMode2D.Impulse);
        _rb.AddTorque(Random.Range(-1 * _torquePower, 1 * _torquePower), ForceMode2D.Impulse);
    }
}
