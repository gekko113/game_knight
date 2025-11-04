using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float cameraSpeed;


    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(player.position.x, player.position.y, 
            transform.position.z), cameraSpeed);
    }
}
