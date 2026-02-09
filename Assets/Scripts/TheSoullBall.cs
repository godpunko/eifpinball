using UnityEngine;

public class TheSoullBall : MonoBehaviour
{

    public float soulMaxHP = 20.0f;
    public float soulHP = 20.0f;
    private float HPLastFrame;

    void Start()
    {
        
        soulHP = soulMaxHP;
        HPLastFrame = soulHP;

    }

    void Update()
    {

        //taken damage
        if(HPLastFrame != soulHP)
        {

            HPLastFrame = soulHP;
            GetComponent<AudioSource>().Play();

        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

            soulHP = soulHP - 5;

        }

        if (soulHP <= 0) { 
            
            soulHP = 0; 
        
        }
        
    }
}
