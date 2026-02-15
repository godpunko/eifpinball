using UnityEngine;

public class TheSoullBall : MonoBehaviour
{

    public float soulMaxHP = 20.0f;
    public float soulHP = 20.0f;
    private float HPLastFrame;
    public float score = 0f;
    public float pacscore = 0f;
    public float genscore = 0f;

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

        if (soulHP <= 0) { 
            
            soulHP = 0; 
        
        }
        
    }
}
