using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using TMPro;

public class Launcher: MonoBehaviourPunCallbacks
{
    [SerializeField] TextMeshProUGUI roomNameInputField;
    [SerializeField] TextMeshProUGUI roomNameText;
    [SerializeField] TextMeshProUGUI errorText;
    
     
       void Start()
    {
        Debug.Log("Connecting to master");
        PhotonNetwork.ConnectUsingSettings(); 
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("You have joined Master");
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        MenuManager.Instance.OpenMenu("title");
        Debug.Log("You have joined lobby");
    }
    
    void Update()
    { 
    }

    public void CreateRoom()
    {
        if(string.IsNullOrEmpty(roomNameInputField.text))
        {
            return;
        }
        Debug.Log("COMING SOON");
        PhotonNetwork.CreateRoom(roomNameInputField.text);
        MenuManager.Instance.OpenMenu("loading");

    }

    public override void OnJoinedRoom()
    {
            MenuManager.Instance.OpenMenu("room");
            roomNameText.text = PhotonNetwork.CurrentRoom.Name; 
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        errorText.text = "Room Creation Failed: " + message;
        MenuManager.Instance.OpenMenu("error");
    }
}
 