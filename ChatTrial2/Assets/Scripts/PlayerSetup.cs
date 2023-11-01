using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    public Movement movement;
    public GameObject camera1;

    public void IslocalPlayer()
    {
        movement.enabled = true;
        camera1.SetActive(true);
    }
}
