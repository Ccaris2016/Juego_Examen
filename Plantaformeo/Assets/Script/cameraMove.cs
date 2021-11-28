using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public GameObject player;
    public GameObject camera;
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > 5.26)
        {
            camera.transform.position = new Vector3((float)5.26, camera.transform.position.y, camera.transform.position.z);
        }
        else if (player.transform.position.x < -0.15)
        {
            camera.transform.position = new Vector3((float)-0.15, camera.transform.position.y, camera.transform.position.z);
        }
        else {
            camera.transform.position = new Vector3(player.transform.position.x,camera.transform.position.y, camera.transform.position.z);
        }
    }
}
