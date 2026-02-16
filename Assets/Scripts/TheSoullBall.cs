using UnityEngine;
using UnityEngine.SceneManagement;

public class TheSoullBall : MonoBehaviour
{

    public float soulMaxHP = 20.0f;
    public float soulHP = 20.0f;
    private float HPLastFrame;
    public float score = 0f;
    public float pacscore = 0f;
    public float genscore = 0f;

    [SerializeField] private AudioClip deathClip;
    [SerializeField] private Sprite deathSprite;
    public bool died = false;

    void Start()
    {
        
        soulHP = soulMaxHP;
        HPLastFrame = soulHP;

    }

    void PlayerInput()
    {

        if(died && Input.GetKeyDown(KeyCode.Tab))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }


    }

    void Update()
    {

        //taken damage
        if(HPLastFrame < soulHP)
        {

            HPLastFrame = soulHP;
            GetComponent<AudioSource>().Play();

        }

        if (soulHP <= 0) {

            if (!died)
            {
                soulHP = 0;
                GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                GetComponent<Rigidbody2D>().linearVelocity = Vector3.zero;
                GetComponent<AudioSource>().clip = deathClip;
                GetComponent<SpriteRenderer>().sprite = deathSprite;
                GetComponent<AudioSource>().Play();
                died = true;
            }
            

        
        } else if (soulHP > soulMaxHP)
        {

            soulHP = soulMaxHP;

        }

        PlayerInput();
        
    }
}
