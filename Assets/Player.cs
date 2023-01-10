using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Camera _camera;
    [SerializeField] Vector3 _cameraOffset = new Vector3(0, 1f, 6f);
    private Rigidbody rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Move();
        Rotate();
    }
    public void Move()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * _speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * _speed;


        transform.Translate(x, 0, z);
    }
    public void Rotate()
    {
        var yRot = Input.GetAxis("Mouse X") * _speed;
        var isRot = yRot != 0;

        transform.Rotate(0, yRot, 0);
        
        _camera.transform.rotation = Quaternion.Lerp(_camera.transform.rotation, transform.rotation, Time.deltaTime * 2);
        _camera.transform.position = Vector3.Lerp(_camera.transform.position, transform.position + _camera.transform.TransformDirection(_cameraOffset), Time.deltaTime * 2);


        var direction = transform.position - _camera.transform.position;
        var rotation = Quaternion.LookRotation(direction);
        _camera.transform.rotation = Quaternion.Lerp(_camera.transform.rotation, rotation, Time.deltaTime * 2);
    }
}
