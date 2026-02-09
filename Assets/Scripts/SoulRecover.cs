using UnityEngine;

public class SoulRecover : MonoBehaviour
{
    [SerializeField] private bool dealsDamage = false;
    [SerializeField] private float damageDealt = 0.0f;
    [SerializeField] private GameObject targetSoul;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball")) { 
            
            collision.transform.position = new Vector3(11, -10, 0); 
        
            if (dealsDamage) {

                targetSoul.GetComponent<TheSoullBall>().soulHP = targetSoul.GetComponent<TheSoullBall>().soulHP - damageDealt;
                targetSoul.GetComponent<Rigidbody2D>().linearVelocity = new Vector3(0, 0, 0);

            }
        
        }
        
    }

}
