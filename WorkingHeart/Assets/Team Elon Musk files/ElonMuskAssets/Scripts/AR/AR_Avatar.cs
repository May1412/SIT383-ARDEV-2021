using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class AR_Avatar : MonoBehaviour
{
    private PhotonView photonView;
    private void Start()
    {
        photonView = GetComponent<PhotonView>();
    }
    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine == true)
        {
            this.gameObject.transform.position = Camera.main.transform.position;
            this.gameObject.transform.rotation = Camera.main.transform.rotation;
        }
    }
}
