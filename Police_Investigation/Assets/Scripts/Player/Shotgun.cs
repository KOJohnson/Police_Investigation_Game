using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Shotgun : MonoBehaviour
{
    [Header("Gun Stats")]
    [SerializeField] private float MAX_DISTANCE = 20f;
    public float ammoCount;
    public float maxAmmo = 6f;
    private float ammoutToReload;
    public float reloadDelay = 0.5f;
    public float ammoReserve;
    private float minAmmo = 0f;
    public float gunDamage;
    private float _nextFire = 0f;
    public float fireRate = 0.2f;
    
    public TextMeshProUGUI ammoCountDsiplay;
    public TextMeshProUGUI ammoReserveDisplay;

    [Header("Gun Sounds/VFX ")] 
    [SerializeField] private AudioSource shootSound;
    [SerializeField] private AudioSource emptyGun;
    [SerializeField] private AudioSource reloadShotgun;
    [SerializeField] private GameObject hitDecal;
    [SerializeField] private ParticleSystem muzzleFlash;

    [SerializeField] private bool canShoot;
    public bool isReloading;
    
    private void Start()
    {
        ammoCount = maxAmmo;
        ammoReserve = 50f;
        gunDamage = 50f;
        
        
        if (ammoCountDsiplay!= null)
            ammoCountDsiplay.text = ammoCount.ToString();
        
        if (ammoReserveDisplay!= null) 
            ammoReserveDisplay.text = ammoReserve.ToString();
        
    }
    
    private void Update()
    {
        ammoCountDsiplay.text = ammoCount.ToString();
        ammoReserveDisplay.text = ammoReserve.ToString();
        
        if (ammoCount > minAmmo && !isReloading)
        {
            canShoot = true;
        }
        else canShoot = false;

        if (CustomPlayerInputManager.instance.leftMousePressed && ammoCount == 0 && !DialogueManager.instance.dialogueIsPlaying)
        {
            emptyGun.Play();
        }

        //cant shoot whilst dialogue is playing
        if (DialogueManager.instance.dialogueIsPlaying)
        {
            canShoot = false;
        }
        if (CustomPlayerInputManager.instance.leftMousePressed && Time.time > _nextFire && canShoot && !isReloading)
        {
            _nextFire = Time.time + fireRate;
            Shooting();
        }
        
        if (CustomPlayerInputManager.instance.rPressed && ammoCount < maxAmmo && ammoReserve > 0)
        {
            isReloading = true;
            // Debug.Log("set bool");
            canShoot = false;
            StartCoroutine(Reload());
        }
        else isReloading = false; canShoot = true;
        
    }
    
    private void Shooting()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, MAX_DISTANCE) && canShoot)
        {
            shootSound.Play();
            muzzleFlash.Play();
            GameObject impactGO = Instantiate(hitDecal, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO,2f);
            
            //ammo down
            ammoCount -= 1;
            
            AgentController target = hit.transform.GetComponent<AgentController>();
            if (target != null)
            {
                target.TakeDamage(gunDamage);
            }
        }
    }

    private IEnumerator Reload()
    {
        isReloading = true;
        while (ammoCount < maxAmmo)
        {
            if (CustomPlayerInputManager.instance.leftMousePressed)
            {
                yield break;
            }
            if (ammoReserve <= 0)
            {
                yield break;
            }
            
            ammoReserve-= 1;
            ammoCount+= 1;
            reloadShotgun.Play();
            yield return new WaitForSeconds(reloadDelay);
        }
        
    }
    
    
    
    
}
