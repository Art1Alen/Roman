using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject player;
    public float offsetX = 0;
    public float offsetZ = -5;
    public float playerVelocity = 5;
    private float _movementX;
    private float _movementZ;


    public void Update()
    {
        _movementX = ((player.transform.position.x + offsetX - this.transform.position.x));
        _movementZ = ((player.transform.position.z + offsetZ - this.transform.position.z));
        this.transform.position += new Vector3((_movementX * playerVelocity * Time.deltaTime), 0, (_movementZ * playerVelocity * Time.deltaTime));
    }
}
