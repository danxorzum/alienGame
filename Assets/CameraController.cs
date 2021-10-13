using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float distance;
    public float speed;
    // Start is called before the first frame update
    private Vector3 _target;
    void Start()
    {
        _target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    private void Center(){
        transform.Translate(player.transform.position * Time.deltaTime * speed);
    }
}
