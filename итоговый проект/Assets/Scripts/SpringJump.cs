using SimpleFPS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SpringJump : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private new AudioSource audio;
    [SerializeField] private new Transform transform;


    private bool isExitingTrigger;
    private float previusJump;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            previusJump = fps.m_JumpSpeed;
            fps.m_JumpSpeed += jumpForce;
            fps.m_Jump = true;
            transform.localPosition -= new Vector3(0, 0.05f, 0);
            audio.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed = previusJump;
            isExitingTrigger = true;
        }
    }
    private void Update()
    {
        if (isExitingTrigger == true && transform.localPosition.y < 0.132f)
        {
            transform.localPosition += new Vector3(0, 0.01f, 0);
        }
        else if (transform.localPosition.y >= 0.132f)
        {
            isExitingTrigger = false; // Остановить подъем, если достигли нужной высоты
        }
    }
}
