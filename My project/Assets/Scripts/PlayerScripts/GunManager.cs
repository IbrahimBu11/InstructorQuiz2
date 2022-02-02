using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    public Camera cam;
    RaycastHit hit;
    public Transform shootPoint;
    Ray ray;

    public LayerMask mask;
    public Color col;
    public List<GameObject> guns;
    private int selectedGunIndex = 0, defaultGunIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        selectedGunIndex = defaultGunIndex;
        col = GetComponent<Renderer>().material.color;
        mask = LayerMask.GetMask("notHitable");
    }

    // Update is called once per frame
    void Update()
    {
        SetShootPos();
        SelectGunOnInput();
        GunEnabler(selectedGunIndex);


    }

    //Setting the position of my crosshair(Aim) where there's a way hitting floor from camera
    void SetShootPos()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 999, ~mask))
            
        {
            shootPoint.position = hit.point;
        }
    }
    //Enables the slected gun and desables the rest
    void GunEnabler(int index)
    {
        foreach(GameObject gun in guns)
        {
            if (gun.name == IndexToname(index))
            {
                gun.SetActive(true);
               // Debug.Log("Activated gun : " + gun.name);
            }
            else
            {
                gun.SetActive(false);
                //Debug.Log("DeActivated gun : " + gun.name);
            }
               
        }
    }
    //Since there is no method to get index of array element i created my own
    string IndexToname(int index)
    {
        return guns[index].name;
    }
    //Select gun indes on user input
    void SelectGunOnInput()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            selectedGunIndex = 0;
            GetComponent<Renderer>().material.color = col;
        }
        else if (Input.GetKey(KeyCode.Alpha2)) 
        { 
            selectedGunIndex = 1;
            GetComponent<Renderer>().material.color = Color.red;
        }
        else if (Input.GetKey(KeyCode.Alpha3)) 
        { 
            selectedGunIndex = 2;
            GetComponent<Renderer>().material.color = Color.green;
        }

        //return 0;
    }
    

}
