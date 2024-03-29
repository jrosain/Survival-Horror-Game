﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFloor : MonoBehaviour
{
    public List<GameObject> toShow;
    public List<GameObject> toHide;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.tag == "Player")
        {
            foreach (GameObject go in toShow)
            {
                go.SetActive(true);
            }
            foreach (GameObject go in toHide)
            {
                go.SetActive(false);
            }
            PlayerManager pm = col.gameObject.GetComponent<PlayerManager>();
            if(pm)
            {
                if (pm.CurrentFloor == 2) pm.CurrentFloor = 1;
                else pm.CurrentFloor = 2;
            }
        }
    }
}
