using UnityEngine;
using TMPro;

public class RayCast : MonoBehaviour
{   

    [Header("Gun Stats")] 
    [SerializeField] private float MAX_DISTANCE = 20f;
    public float ammoCount;
    private float minAmmo;
    public float gun_damage;
    float nextFire = 0f;
    public float fireRate = 0.2f;
    public TextMeshProUGUI AmmoCountDisplay;

    [SerializeField] private bool canShoot;

    private void Start() 
    {
        ammoCount = 6f;
        minAmmo = 0f;
        gun_damage = 45f;
    }
    void Update()
    {
        //update ammo count
        AmmoCountDisplay.text = ammoCount.ToString();

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
            //store hit distance in float //rounds to the nearest integer

            float distance = Mathf.Round(Hit.distance);
            //Debug.LogFormat("Object = {0} and Distance = {1}", Hit.transform.name, distance);

            AgentController target = Hit.transform.GetComponent<AgentController>();

            if(target != null)
            {
                target.TakeDamage(gun_damage);
                //Debug.Log("Enemy hit!");
            }

        }
    }
}
