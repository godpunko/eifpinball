using UnityEngine;

public class SpringThing : MonoBehaviour
{

    [SerializeField] private float squeezePower = 0.1f;
    [SerializeField] SpringJoint2D springJoint;
    [SerializeField] private float squeezeDistance = 1f;
    private float ogDistance;
    private bool peakTriggered = false;



    private void Awake()
    {
        
        springJoint = GetComponent<SpringJoint2D>();
        ogDistance = springJoint.distance;

    }

    private void PlayerInput()
    {

        if (Input.GetKey(KeyCode.Space)) {

            springJoint.distance = Mathf.Lerp(springJoint.distance, squeezeDistance, squeezePower);

            if (!peakTriggered && springJoint.distance <= 1.6f) { 
                
                
                peakTriggered = true;
                GetComponent<AudioSource>().Play();
                GetComponent<SpriteRenderer>().color = new Color32(238,255,45,255);

            }
        
        }
        else
        {

            springJoint.distance = ogDistance;
            peakTriggered = false;
            GetComponent<SpriteRenderer>().color = new Color32(46,255,45,255);

        }

    }

    // Update is called once per frame
    void Update()
    {

        PlayerInput();
        
    }
}
