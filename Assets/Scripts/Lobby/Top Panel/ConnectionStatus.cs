﻿using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public sealed class ConnectionStatus : MonoBehaviour
{
    [Header("Connection Info")]
    [SerializeField] Text connectionStatusText;
    [SerializeField] Text pingText;

    void Update()
    {
        connectionStatusText.text = $"\tConnection status: {PhotonNetwork.NetworkClientState}";
        pingText.text = $"Ping: {PhotonNetwork.GetPing()} ms";
    }
}
