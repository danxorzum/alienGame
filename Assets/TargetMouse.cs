using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMouse : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        Debug.Log(mousePos);
        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(rotation, transform.rotation, rotationSpeed * Time.deltaTime);
    }
}
