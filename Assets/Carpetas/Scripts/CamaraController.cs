using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public Protagonista player;
    void Update()
    {
        if (player != null)
        {
            Vector2 newCamPositionX = new Vector2(player.transform.position.x, 0);
            Vector2 newCamPositionY = new Vector2(0, player.transform.position.y);
            transform.position = new Vector3(newCamPositionX.x, newCamPositionY.y, transform.position.z);
        }
    }
}
