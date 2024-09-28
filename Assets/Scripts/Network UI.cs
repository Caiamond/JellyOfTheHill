using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FishNet;

public class NetworkUI : MonoBehaviour
{
    public Button hostButton;
    public Button clientButton;
    
    // Start is called before the first frame update
    void Start()
    {
        hostButton.onClick.AddListener(StartHost);
        clientButton.onClick.AddListener(StartClient);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartHost()
    {
        InstanceFinder.ServerManager.StartConnection();
    }

    void StartClient()
    {
        InstanceFinder.ClientManager.StartConnection();
    }

}
