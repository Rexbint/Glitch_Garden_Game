using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVolume : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefsController.SetMasterVolume(0.4f);
        Debug.Log(PlayerPrefsController.GetMasterVolume());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
