using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCameraAssign : MonoBehaviour
{
  
    void Start()
    {
        
    }

    private void OnEnable()
    {
        Services.instance.CameraUpdateAssign();
        Debug.Log("enable is work");
    }
    
    public void MainMenu()
    {
        Services.GameService.SetState<MenuState>();
    }

}
