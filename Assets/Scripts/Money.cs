using UnityEngine;

public class Money : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject); 
            Inventory inventory = other.GetComponent<Inventory>();
            inventory.AddMoney();
        }
    }
}
