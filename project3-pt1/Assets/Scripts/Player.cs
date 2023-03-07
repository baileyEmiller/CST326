using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using static Enemy;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    public Transform shottingOffset;
    public bool cooldown = false;
    int timeAtLastShot = 0;
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space) && !cooldown)
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");
        Destroy(shot, 3f);
        cooldown = true;
        timeAtLastShot = (int)Math.Floor(Time.realtimeSinceStartup);
      }

      if(timeAtLastShot + 1 == (int)Math.Floor(Time.realtimeSinceStartup)){
            cooldown = false;
        }

      if(Input.GetKeyDown(KeyCode.A))
        {
            this.transform.position = this.transform.position += new Vector3(-.5f, 0, 0);
        }
      if (Input.GetKeyDown(KeyCode.D))
      {
            this.transform.position = this.transform.position += new Vector3(.5f, 0, 0);
      }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
        Destroy(collision.gameObject);
    }
}
