using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private     Rigidbody2D     _playerRb;
    private float _angle = 0f;

    [SerializeField] private float _speed;
    [SerializeField] private float _radius;
    [SerializeField] private Transform _center;
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        //_angle += movement * _speed * Time.deltaTime;

        transform.Rotate(0, 0, movement * _speed * Time.deltaTime);

        /*_angle += movement * _speed * Time.deltaTime;

        float x = Mathf.Cos(_angle) * _radius;
        float y = Mathf.Sin(_angle) * _radius;

        transform.position = new Vector3(x, y, 0f) + _center.position;*/
    }
}
