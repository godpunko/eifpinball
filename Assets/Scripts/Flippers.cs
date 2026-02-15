using UnityEngine;

public class Flippers : MonoBehaviour
{

    private HingeJoint2D joint;
    private JointMotor2D motor;
    [SerializeField] private float motorSpeed = 1.0f;
    [SerializeField] private KeyCode control;

    [SerializeField] private AudioClip pressSound;
    [SerializeField] private AudioClip hitSound;
    private bool pressed = false;

    private void Start()
    {
        
        joint = GetComponent<HingeJoint2D>();
        motor = joint.motor;

        joint.useMotor = false;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        GetComponent<AudioSource>().clip = hitSound;
        GetComponent<AudioSource>().Play();

    }

    private void PlayerInput()
    {

        if (Input.GetKey(control))
        {

            motor.motorSpeed = motorSpeed;
            joint.motor = motor;
            joint.useMotor = true;

            if (!pressed) {

                GetComponent<AudioSource>().clip = pressSound;
                GetComponent<AudioSource>().Play();
                pressed = true;
                GetComponent<SpriteRenderer>().color = new Color32(238, 255, 45, 255);

            }
            

        }
        else
        {

            joint.useMotor = false;
            pressed = false;
            GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 255);

        }

    }

    private void Update()
    {
        
        PlayerInput();

    }

}
