using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Player _player;
    
    public bool IsPlayerRotates = false;
    private Transform transform;
    
    void Start()
    {
        transform = base.GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //if (!IsPlayerRotates)
        //{
        //    transform.position = Vector3.Lerp(transform.position, _player.transform.position + PlayerOffset, Time.deltaTime * 2);


        //    var direction = _player.transform.position - transform.position;
        //    var rotation = Quaternion.LookRotation(direction);
        //    transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * 5);
        //}
    }
}
