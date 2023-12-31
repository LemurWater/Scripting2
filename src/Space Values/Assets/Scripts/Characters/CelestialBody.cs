using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CelestialBody : MonoBehaviour
{
    [SerializeField] private protected float speed;
    [SerializeField] private protected Transform matrioskaBrain;



    public StarSpawner Spawner { get; set; }
    public float Speed { get => speed; private set => speed = value; }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GravityField();
    }




    public virtual void ResetState(bool state)
    {
        if (state)
        {
            gameObject.SetActive(true);
            speed = 10.0f;
        }
        else
        {
            speed = 0.0f;
            gameObject.SetActive(false);
            //GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }


    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    #region Private
    private protected void GravityField()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, matrioskaBrain.position, step);
    }


    private protected virtual void CheckTrigger(Collider collider)
    {
        if (collider != null)
        {
            GameObject go = collider.gameObject;

            if (go.tag == "Matrioska Brain")
            {
                Debug.Log("Collision: Matrioska Brain (" + this.tag + ")");
                DestroyCelestialBody();
                return;
            }
        }
    }
    private protected virtual void DestroyCelestialBody()
    {
        //Destroy(gameObject);
        //Spawner?.Recycle(this);
    }
    #endregion Private
}
