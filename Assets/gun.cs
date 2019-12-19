using System.Collections;
using UnityEngine;


public class gun : MonoBehaviour
{
public float damage = 10f;
public float range = 100f;

public bool doorOpened = false;
public bool door1Opened = false;
public bool door2Opened = false;
public bool door3Opened = false;
public bool door4Opened = false;
public bool door5Opened = false;
public bool door6Opened = false;
public bool door7Opened = false;
public bool door8Opened = false;
public bool door9Opened = false;
public bool door10Opened = false;
public bool door11Opened = false;
public bool door12Opened = false;
public bool door13Opened = false;
public bool door14Opened = false;
public bool door15Opened = false;

public Camera fpsCam;

public GameObject enemy;

public GameObject door;
public GameObject door1;
public GameObject door2;
public GameObject door3;
public GameObject door4;
public GameObject door5;
public GameObject door6;
public GameObject door7;
public GameObject door8;
public GameObject door9;
public GameObject door10;
public GameObject door11;
public GameObject door12;
public GameObject door13;
public GameObject door14;
public GameObject door15;

// public float y = transform.position.y;
    // Update is called once per frame

    // Start is called before the first frame update
    void Start()
    {
     enemy = GameObject.FindWithTag("Enemy");
     door = GameObject.FindWithTag("Door");
     door1 = GameObject.FindWithTag("Door1");
     door2 = GameObject.FindWithTag("Door2");
     door3 = GameObject.FindWithTag("Door3");
     door4 = GameObject.FindWithTag("Door4");
     door5 = GameObject.FindWithTag("Door5");
     door6 = GameObject.FindWithTag("Door6");
     door7 = GameObject.FindWithTag("Door7");
     door8 = GameObject.FindWithTag("Door8");
     door9 = GameObject.FindWithTag("Door9");
     door10 = GameObject.FindWithTag("Door10");
     door11 = GameObject.FindWithTag("Door11");
     door12 = GameObject.FindWithTag("Door12");
     door13 = GameObject.FindWithTag("Door13");
     door14 = GameObject.FindWithTag("Door14");
     door15 = GameObject.FindWithTag("Door15");
     
        
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    

    void Shoot ()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)){

            Debug.Log(hit.transform.name);

        if(hit.collider.tag == "Enemy"){
            
            Destroy(enemy);
        }
            
            
        }
        if(hit.collider.tag == "Door"){
            doorOpened = true;
            Debug.Log(doorOpened);
            door.transform.Translate(0, 0, 4);
            Invoke("closeDoor", 3f);
        }
        
        if(hit.collider.tag == "Door1"){
            door1Opened = true;
            door1.transform.Translate(0, 0, 4);
            Invoke("closeDoor1", 3f);
        }
        if(hit.collider.tag == "Door2"){
            door2Opened = true;
            door2.transform.Translate(0, 0, 4);
            Invoke("closeDoor2", 3f);
        }
        if(hit.collider.tag == "Door3"){
            door3Opened = true;
            door3.transform.Translate(0, 0, 4);
            Invoke("closeDoor3", 3f);
        }
        if(hit.collider.tag == "Door4"){
            door4Opened = true;
            door4.transform.Translate(0, 0, 4);
            Invoke("closeDoor4", 3f);
        }
        if(hit.collider.tag == "Door5"){
            door5Opened = true;
            door5.transform.Translate(0, 0, 4);
            Invoke("closeDoor5", 3f);
        }
        if(hit.collider.tag == "Door6"){
            door6Opened = true;
            door6.transform.Translate(0, 0, 4);
            Invoke("closeDoor6", 3f);
        }
        if(hit.collider.tag == "Door7"){
            door7Opened = true;
            door7.transform.Translate(0, 0, 4);
            Invoke("closeDoor7", 3f);
        }
        if(hit.collider.tag == "Door8"){
            door8Opened = true;
            door8.transform.Translate(0, 0, 4);
            Invoke("closeDoor8", 3f);
        }
        if(hit.collider.tag == "Door9"){
            door9Opened = true;
            door9.transform.Translate(0, 0, 4);
            Invoke("closeDoor9", 3f);
        }
        if(hit.collider.tag == "Door10"){
            door10Opened = true;
            door10.transform.Translate(0, 0, 4);
            Invoke("closeDoor10", 3f);
        }
        if(hit.collider.tag == "Door11"){
            door11Opened = true;
            door11.transform.Translate(0, 0, 4);
            Invoke("closeDoor11", 3f);
        }
        if(hit.collider.tag == "Door12"){
            door12Opened = true;
            door12.transform.Translate(0, 0, 4);
            Invoke("closeDoor12", 3f);
        }
        if(hit.collider.tag == "Door13"){
            door13Opened = true;
            door13.transform.Translate(0, 0, 4);
            Invoke("closeDoor13", 3f);
        }
        if(hit.collider.tag == "Door14"){
            door14Opened = true;
            door14.transform.Translate(0, 0, 4);
            Invoke("closeDoor14", 3f);
        }
        if(hit.collider.tag == "Door15"){
            door15Opened = true;
            door15.transform.Translate(0, 0, 4);
            Invoke("closeDoor15", 3f);
        }

    }
    void closeDoor(){
        
        if(doorOpened == true){
            door.transform.Translate(0, 0, -4);
        }
    }
    void closeDoor1(){
        
        if(door1Opened == true){
            door1.transform.Translate(0, 0, -4);
        }
    }
    void closeDoor2(){
        if(door2Opened == true){
            door2.transform.Translate(0, 0, -4);
        }
    }

    void closeDoor3(){
        if(door3Opened == true){
            door3.transform.Translate(0, 0, -4);
        }
    }

    void closeDoor4(){
        if(door4Opened == true){
            door4.transform.Translate(0, 0, -4);
        }
    }

    void closeDoor5(){
        if(door5Opened == true){
            door5.transform.Translate(0, 0, -4);
        }
    }
    void closeDoor6(){
        if(door6Opened == true){
            door6.transform.Translate(0, 0, -4);
        }
    }

    void closeDoor7(){
        if(door7Opened == true){
            door7.transform.Translate(0, 0, -4);
        }
    }

    void closeDoor8(){
        if(door8Opened == true){
            door8.transform.Translate(0, 0, -4);
        }
    }

    void closeDoor9(){
        if(door9Opened == true){
            door9.transform.Translate(0, 0, -4);
        }
    }

    void closeDoor10(){
        if(door10Opened == true){
            door10.transform.Translate(0, 0, -4);
        }
    }

    void closeDoor11(){
        if(door11Opened == true){
            door11.transform.Translate(0, 0, -4);
        }
    }

    void closeDoor12(){
        if(door12Opened == true){
            door12.transform.Translate(0, 0, -4);
        }
    }
    void closeDoor13(){
        if(door13Opened == true){
            door13.transform.Translate(0, 0, -4);
        }
    }
    void closeDoor14(){
        if(door14Opened == true){
            door14.transform.Translate(0, 0, -4);
        }
    }
    void closeDoor15(){
        if(door15Opened == true){
            door15.transform.Translate(0, 0, -4);
        }

    }
}
