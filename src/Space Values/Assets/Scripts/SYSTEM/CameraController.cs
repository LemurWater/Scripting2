using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Space(10)]

    [Header("Control")]
    [SerializeField] internal bool follow_character = true;
    [SerializeField] internal bool can_rotate = true;
    [Space(20)]
    [SerializeField] private float sensitivity = 450.0f;
    [Space(20)]
    [SerializeField] private Transform body;
    [SerializeField] private Transform spring_arm;


    [SerializeField] private float spring_arm_lenght = 5.0f;


    float xRotation = 0f;
    public float maxYAngle = 80f;
    private Vector2 currentRotation;


    // Start is called before the first frame update
    private void Start()
    {
        //SetSpringArmLenght(springArmLenght);
    }

    // Update is called once per frame
    private void Update()
    {
        direction();

        //rotate();
        follow();
    }

    private void direction()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.magenta);
    }


    private void follow()
    {
        if (follow_character)
        {
            transform.position = spring_arm.position;
        }
    }
    private void rotate()
    {
        if (can_rotate)
        {
            spring_arm.transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime, 0); ;
            spring_arm.transform.Rotate(-Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime, 0, 0);

            currentRotation.x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
            currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
            currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);
            spring_arm.transform.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);


            float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            body.transform.Rotate(Vector3.up * mouseX);

            transform.rotation = spring_arm.rotation;
        }
    }

    public void Change_Body(Transform new_body, Transform new_spring_arm)
    {
        body = new_body;
        spring_arm = new_spring_arm;
    }
    private void set_spring_arm_lenght(float new_lenght)
    {
        spring_arm_lenght = new_lenght;
        //UpdateSpringArm();

        // transform.SetParent(springArm);
    }
    private void update_spring_arm()
    {
        Vector3 v = new Vector3(spring_arm.transform.position.x, spring_arm.transform.position.y, spring_arm_lenght);
        transform.localPosition = v;
    }
}