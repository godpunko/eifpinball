using UnityEngine;

public class SoulRecover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball")) { collision.transform.position = new Vector3(11, -10, 0); }
        
    }

}
