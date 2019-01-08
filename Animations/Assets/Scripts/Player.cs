using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    private int horizontalID = Animator.StringToHash("Horizontal");
    private int speedRotateID = Animator.StringToHash("SpeedRotate");
    private int speedZID = Animator.StringToHash("SpeedZ");
    private int vaultID = Animator.StringToHash("Vault");
    private int colliderID = Animator.StringToHash("Collider");
    private int sliderID = Animator.StringToHash("Slider");
    private int isHoldLogID = Animator.StringToHash("IsHoldLog");


    public Vector3 matchTarget = Vector3.zero;
    private CharacterController charactorController;
    public GameObject Log = null;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        charactorController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat(speedZID, Input.GetAxis("Vertical")*3.85f);
        anim.SetFloat(speedRotateID, Input.GetAxis("Horizontal") * 126f);

        ProcessVault(); // 翻越动画
        ProcessSlider();    // 划过动画


        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Vault") && !anim.IsInTransition(0))
        {
            anim.MatchTarget(matchTarget, Quaternion.identity, AvatarTarget.LeftHand, new MatchTargetWeightMask(Vector3.one, 0), 0.32f, 0.4f);
        }
        if (anim.GetFloat(colliderID) < 0.05)
        {
            charactorController.enabled = true;
        }
        else
        {
            charactorController.enabled = false;
        }
        print(anim.GetFloat(colliderID));
    }

    private void ProcessVault(){
        bool isVault = false;
        if (anim.GetFloat(speedZID) > 3 && anim.GetCurrentAnimatorStateInfo(0).IsName("Locomotion"))
        {
            RaycastHit hit;
            bool isEnough = Physics.Raycast(transform.position + Vector3.up * 0.3f, transform.forward, out hit, 4f);
            if (isEnough)
            {
                if (hit.collider.tag == "Obstacle")
                {
                    if (hit.distance > 3)
                    {
                        Vector3 point = hit.point;
                        point.y = hit.collider.transform.position.y + hit.collider.bounds.size.y + 0.07f;
                        matchTarget = point;
                        isVault = true;
                    }
                }
            }
        }
        anim.SetBool(vaultID, isVault);
    }

    private void ProcessSlider()
    {
        bool isSlider = false;
        if(anim.GetFloat(speedZID) > 3 && anim.GetCurrentAnimatorStateInfo(0).IsName("Locomotion"))
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position + Vector3.up * 1.5f, transform.forward, out hit, 3f))
            {
                if(hit.collider.tag == "Obstacle")
                {
                    if(hit.distance > 2)
                    {
                        Vector3 point = hit.point;
                        point.y = 0;
                        matchTarget = point + transform.forward * 2;

                        isSlider = true;
                    }
                }
            }
        }
        anim.SetBool(sliderID, isSlider);
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("Slider") && !anim.IsInTransition(0))
        {
            anim.MatchTarget(matchTarget, Quaternion.identity, AvatarTarget.Root, new MatchTargetWeightMask(new Vector3(1, 0, 1), 0), 0.17f, 0.67f);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Log")
        {
            Destroy(other.gameObject);
            CarryLog();
        }
    }


    private void CarryLog()
    {
        Log.SetActive(true);
        anim.SetBool(isHoldLogID, true);
    }

}