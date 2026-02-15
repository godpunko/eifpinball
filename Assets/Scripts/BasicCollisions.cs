using UnityEngine;

public class BasicCollisions : MonoBehaviour
{

    [SerializeField] private bool dealsDamage = false;
    [SerializeField] private float damageDealt = 0.0f;
    [SerializeField] private GameObject targetSoul;

    [SerializeField] private bool givesPoints = false;
    [SerializeField] private float pointsDealt = 0f;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ball"))
        {

            if (dealsDamage)
            {

                targetSoul.GetComponent<TheSoullBall>().soulHP = targetSoul.GetComponent<TheSoullBall>().soulHP - damageDealt;

            }
            
            if (givesPoints)
            {

                targetSoul.GetComponent<TheSoullBall>().score = targetSoul.GetComponent<TheSoullBall>().score + pointsDealt;

            }


            GetComponent<AudioSource>().Play();

        }

    }

}
