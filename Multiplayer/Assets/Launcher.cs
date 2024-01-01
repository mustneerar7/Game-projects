using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks
{
    public PhotonView PlayerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }


    public override void OnJoinedRoom()
    {
        Debug.Log("joined room successfully");
        PhotonNetwork.Instantiate(PlayerPrefab.name, Vector3.zero, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
