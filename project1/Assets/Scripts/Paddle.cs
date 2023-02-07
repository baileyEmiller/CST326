using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float max;
    public float min;
    public string inputAxes;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis(inputAxes);
        Vector3 newPosition = transform.position + new Vector3(0, 0, direction) * speed * Time.deltaTime;
        newPosition.z = Mathf.Clamp(newPosition.z, min, max);
        transform.position = newPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "player1")
        {
           collision.rigidbody.velocity = new Vector3(3f, 0f, 0f);
        } else if (gameObject.tag == "player2")
        {
           collision.rigidbody.velocity = new Vector3(-3f, 0f, 0f);
        }
    }
}
