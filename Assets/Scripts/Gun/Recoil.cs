using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoil : MonoBehaviour
{
    public Gun gunScript;

    //recoil variables
    private Vector3 currentRotation;

    private Vector3 targetRotation;

    [SerializeField] private float recoilx = 10;
    [SerializeField] private float recoily = 10;
    [SerializeField] private float recoilz = 10;

    [SerializeField] private float snappiness;
    [SerializeField] private float returnSpeed;

    // Update is called once per frame
    private void Update()
    {
        targetRotation = Vector3.Lerp(Vector3.zero, Vector3.zero, returnSpeed * Time.deltaTime);
        currentRotation = Vector3.Lerp(currentRotation, targetRotation, snappiness * Time.fixedDeltaTime);
        transform.localRotation = Quaternion.Euler(currentRotation);

        if (gunScript.shooting == true)
        {
            RecoilMethod();
        }
    }

    public void RecoilMethod()
    {
        targetRotation += new Vector3(-recoilx, Random.Range(0, recoily), Random.Range(0, recoilz));
    }

    public void StopRecoil()
    {
    }
}