using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class DeactivateMovement : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        if (!photonView.IsMine)
        {
            Debug.Log("Wrong Movement Problem");
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
}
