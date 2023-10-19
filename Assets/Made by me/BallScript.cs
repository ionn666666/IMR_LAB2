using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public bool didNotThrow = true;
    public GameScript gameScript;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(this.name + " hit something");
        //Debug.Log(collision.gameObject.name);
        if (didNotThrow)
        {
            switch (collision.gameObject.name)
            {
                case "Range3":
                    gameScript.AddPoints(1);
                    didNotThrow = false;
                    StartCoroutine(waitAndRun());
                    break;
                case "Range2":
                    gameScript.AddPoints(2);
                    didNotThrow = false;
                    StartCoroutine(waitAndRun());
                    break;
                case "Range1":
                    gameScript.AddPoints(3);
                    didNotThrow = false;
                    StartCoroutine(waitAndRun());
                    break;
                case "Range0":
                    gameScript.AddPoints(5);
                    didNotThrow = false;
                    StartCoroutine(waitAndRun());
                    break;
                default:
                    Debug.Log("I hit walls or floor");
                    break;
            }
        }
    }

    public IEnumerator waitAndRun()
    {
        //to make them stick instead of bounce
        /*
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        */
        yield return new WaitForSeconds(5);
        Debug.Log("Hi im deleting");
        Destroy(this.gameObject);
    }
}
