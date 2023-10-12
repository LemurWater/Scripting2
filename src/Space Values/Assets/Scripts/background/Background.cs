using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Background : MonoBehaviour
{
    public GameObject goStar;

    public Transform hbOrigen;
    public Transform hbBorder;
    public Transform transStars;

    public List<GameObject> stars;


    public float deleteTimer = 0.2f;
    public float createTimer = 0.1f;
    public float createRange = 10.0f;
    public float xTimer = 0.1f;
    public float xFactorTransform = 1.0f;

    [Space(10)]
    public float minSpeed;
    public float maxSpeed;



    private float createTimerMax;
    private float deleteTimerMax;

    [Space(5)]
    [Header("Colors")]
    public Color color1;
    public Color color2;

    private byte[] randomTable = new byte[6] { 10, 10, 5, 8, 15, 15 };
    private byte colorIndex = 0;
    private byte colorIndexMax = 0;



    // Start is called before the first frame update
    void Start()
    {
        createTimerMax = createTimer;
        deleteTimerMax = deleteTimer;

        colorIndex = 0;
        colorIndexMax = 10;
    }

    // Update is called once per frame
    void Update()
    {
        DeleteStars();
        CreateStars();
    }

    public void DeleteStars()
    {
        if (deleteTimer <= 0)
        {
            foreach (var s in stars)
            {
                if (s.transform.position.y < hbBorder.position.y)
                {
                    Destroy(s.gameObject);
                }
            }
            deleteTimer = deleteTimerMax;
        }
        else
        {
            deleteTimer = deleteTimer - xTimer * Time.deltaTime;
        }
    }
    public void CreateStars()
    {
        if (createTimer <= 0)
        {
            GameObject s = Instantiate(goStar, transStars);
            stars.Add(s);

            float a = Random.Range(-createRange - hbOrigen.transform.position.x, createRange + hbOrigen.transform.position.x);
            Vector3 newPos = new Vector3(a, hbOrigen.transform.position.y, 0);

            s.GetComponent<Star>().speed = RandomSpeed();
            ChangeSize(s);
            s.transform.position = newPos;


            createTimer = createTimerMax;


            SpriteRenderer sr = s.GetComponent<SpriteRenderer>();
            sr.color = RandomColor();
        }
        else
        {
            createTimer = createTimer - (xTimer/2) * Time.deltaTime;
        }
    }

    private float  RandomSpeed()
    {
        return Random.Range(minSpeed, maxSpeed);
    }
    private void ChangeSize(GameObject star)
    {
        Star scriptStar = star.GetComponent<Star>();
        star.transform.localScale = star.transform.localScale  * scriptStar.speed * xFactorTransform;
    }

    private Color RandomColor()
    {
        /*if(colorIndex >= randomTable[colorIndexMax] - 1)
        {

            colorIndex = 0;
            colorIndexMax++;

            return color2;
        }
        else
        {
            colorIndex++;
            return color1;
        }*/
        return Color.white;
    }
}
