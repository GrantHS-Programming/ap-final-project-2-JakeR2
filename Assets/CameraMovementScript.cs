using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    private float maxHeight = 0;
    private float currentPosY;

    [SerializeField] private Transform player;

    private void Update()
    {
        if (player.position.y > maxHeight)
        {
            maxHeight = player.position.y;
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }
    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPosY = _newRoom.position.y;
    }
}
