using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Revolver : MonoBehaviour
{
   
    [Header("Gun Stats")] 
    [SerializeField] private float MAX_DISTANCE = 20f;
    public float ammoCount;
    public float ammoReserve;
    private float minAmmo = 0f;
    public float gun_damage;
    float nextFire = 0f;
    public float fireRate = 0.2f;
    public TextMeshProUGUI AmmoCountDisplay;
    public TextMeshProUGUI ammoReserveDisplay;

    [SerializeField] private bool canShoot;

    private void Start() 
    {
        ammoCount = 6f;
        ammoReserve = 0f;
        gun_damage = 45f;
        
        AmmoCountDisplay.text = ammoCount.ToString();
        ammoReserveDisplay.text = ammoReserve.ToString();
    }
    void Update()
    {
        if(ammoCount > minAmmo)
        {
            canShoot = true;
        }
        else canShoot = false;
    
        //cant shoot whilst dialogue is playing
        if (DialogueManager.instance.dialogueIsPlaying)
        {
            canShoot = false;
        }
        if(CustomPlayerInputManager.instance.leftMousePressed && Time.time > nextFire && canShoot)
        {
            nextFire = Time.time + fireRate;
            Shooting();
        }
    }

    void Shooting()
    { 
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit Hit;
        if(Physics.Raycast(ray, out Hit, MAX_DISTANCE) && canShoot)
        { 
            // ammo down
            ammoCount -= 1;
            //update ammo count after shooting
            AmmoCountDisplay.text = ammoCount.ToString();
            
            //store hit distance in float //rounds to the nearest integer
            float distance = Mathf.Round(Hit.distance);
            //Debug.LogFormat("Object = {0} and Distance = {1}", Hit.transform.name, distance);

            EnemyStats target = Hit.transform.GetComponent<EnemyStats>();

            if(target != null)
            {
                target.TakeDamage(gun_damage);
                //Debug.Log("Enemy hit!");
            }
        }
    }
}