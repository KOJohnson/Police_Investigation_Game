using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Apple.ReplayKit;

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

    [Header("Gun Recoil")] 
    private Vector3 _startRotation;
    public Vector3 upRecoil;
    public float resetSpeed;

    [Header("Gun Sounds/VFX ")] 
    [SerializeField] private AudioSource shootSound;
    //[SerializeField] private AudioSource emptyAmmoSound;
    [SerializeField] private GameObject hitDecal;
    [SerializeField] private ParticleSystem muzzleFlash;

    [SerializeField] private bool canShoot;
    public bool isReloading;
    

    // Start is called before the first frame update
    private void Start()
    {
        ammoCount = maxAmmo;
        ammoReserve = 0f;
        gunDamage = 50f;

        _startRotation = transform.localEulerAngles;
        
        if (ammoCountDsiplay!= null)
            ammoCountDsiplay.text = ammoCount.ToString();
        
        if (ammoReserveDisplay!= null) 
            ammoReserveDisplay.text = ammoReserve.ToString();
        
    }

    // Update is called once per frame
    private void Update()
    {
        ammoCountDsiplay.text = ammoCount.ToString();
        
        if (ammoCount > minAmmo && !isReloading)
        {
            canShoot = true;
        }
        else canShoot = false;

        //cant shoot whilst dialogue is playing
        if (DialogueManager.instance.dialogueIsPlaying)
        {
            canShoot = false;
        }
        if (CustomPlayerInputManager.instance.leftMousePressed && Time.time > _nextFire && canShoot && !isReloading)
        {
            _nextFire = Time.time + fireRate;
            Shooting();
            AddRecoil();
            
        }
        
        

        if (CustomPlayerInputManager.instance.rPressed && ammoCount < maxAmmo)
        {
            StartCoroutine(Reload());
        }
        else isReloading = false;
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
            
            EnemyStats target = hit.transform.GetComponent<EnemyStats>();
            if (target != null)
            {
                target.TakeDamage(gunDamage);
                //Debug.Log("Enemy hit!");
            }
        }
    }

    private IEnumerator Reload()
    {
        isReloading = true;
        while (ammoCount < maxAmmo)
        {
            ammoCount+= 1;
            yield return new WaitForSeconds(reloadDelay);
        }
        
    }

    private void AddRecoil()
    {
        transform.localEulerAngles = Vector3.Slerp(_startRotation, upRecoil, resetSpeed);
    }

    private void ResetRecoil()
    {
        transform.localEulerAngles = Vector3.Slerp(upRecoil, _startRotation, resetSpeed);
    }

    
}
