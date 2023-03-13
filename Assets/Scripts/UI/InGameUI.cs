

    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InGameUI : MonoBehaviour
{
    public TMP_Text magSizeTMP;
    public TMP_Text bulletsLeftTMP;

    public Gun gun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletsLeftTMP.text = gun.bulletsLeft.ToString();
        magSizeTMP.text =gun.magazineSize.ToString();
    }
}
