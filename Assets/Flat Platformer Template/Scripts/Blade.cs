using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    public int damage = 100; 
    
    private bool isRotating = false;
    private float startRotation = 34.714f;
    private float endRotation = 0f;
    private float rotationSpeed = 500f;
    private float waitTime = 0.5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isRotating)
        {
            StartCoroutine(RotateObject());
        }
    }

    IEnumerator RotateObject()
    {
        isRotating = true;

        while (transform.rotation.eulerAngles.z > endRotation)
        {
            float newRotation = Mathf.MoveTowardsAngle(transform.rotation.eulerAngles.z, endRotation, rotationSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, newRotation);
            yield return null;
        }

        yield return new WaitForSeconds(waitTime);

        while (transform.rotation.eulerAngles.z < startRotation)
        {
            float newRotation = Mathf.MoveTowardsAngle(transform.rotation.eulerAngles.z, startRotation, rotationSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, newRotation);
            yield return null;
        }

        isRotating = false;
    }
}







        // hvis den er mirror så skal startRotation være -34.714f;



      /*  // Sværdet danser
        transform.Rotate(new Vector3(1, 0, 0)); */


