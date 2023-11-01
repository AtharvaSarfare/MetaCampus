using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class DeactivateIfNotMyCamera : MonoBehaviourPunCallbacks
{
    void Start()
    {
        if (!photonView.IsMine)
        {
            Debug.Log("Wrong Camera Problem");
            gameObject.SetActive(false);
        }
    }
}
