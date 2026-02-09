using UnityEngine;

public class Flippers : MonoBehaviour
{

    private HingeJoint2D joint;
    private JointMotor2D motor;
    [SerializeField] private float motorSpeed = 1.0f;

    private void Start()
    {
        
        joint = GetComponent<HingeJoint2D>();
        motor = joint.motor;

        joint.useMotor = false;

    }

    private void PlayerInput()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {

            motor.motorSpeed = motorSpeed;
            joint.motor = motor;
            joint.useMotor = true;

        }
        else
        {

            joint.useMotor = false;

        }

    }

    private void Update()
    {
        
        PlayerInput();

    }

}
