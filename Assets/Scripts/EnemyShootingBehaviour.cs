using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyShootingBehaviour : MonoBehaviour
{
    public Transform target;
    public float shotRange = 10f;
    public float coolDownTime = 2f;
    private bool inCooldown = false;
    private Shoot shootScript;
    private TriggerAnimation triggerAnimationScript;
    // Start is called before the first frame update
    void Start()
    {
        shootScript = GetComponentInChildren<Shoot>();
        triggerAnimationScript = GetComponentInChildren<TriggerAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(target.position.x, transform.position.y, target.position.z);
        transform.LookAt(targetPos);

        Vector3 delta = transform.position - target.position;

        if (delta.magnitude < shotRange && !inCooldown)
        {
            shootScript.CallShot();
            triggerAnimationScript.CallTrigger();
            inCooldown = true;
            StartCoroutine(Cooldown(coolDownTime));
        }

    }
    private IEnumerator Cooldown(float time)
    {
        yield return new WaitForSeconds(time);
        inCooldown = false;
    }
}
