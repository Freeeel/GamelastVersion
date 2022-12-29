using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject EnityDial;
    public GameObject zav;
    void Update()
    {
        if (Trigger1floor.conva == true)
        {
            Destroy(EnityDial);
            Destroy(zav);
        }
    }
}
