using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay1 : MonoBehaviour
{
    [SerializeField]
    AudioClip scene01;
    [SerializeField]
    AudioClip scene02;

    //private AudioClip[] clips;
    public AudioSource audioSource;
    //public GameObject mal;
    //public AudioSource audioSource;
    //public AudioClip clip;
    //public float volume = 0.5f;
    // Start is called before the first frame update
    private void Awake()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    private void Hello()
    {
        AudioClip clip = scene01;
        audioSource.PlayOneShot(clip);
    }
    private void Bye()
    {
        AudioClip clip = scene02;
        audioSource.PlayOneShot(clip);
    }
    void Start()
    {

        //AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
        //AudioSource audioSource = mal.GetComponent<AudioSource>();
        //audioSource.PlayOneShot(clip, volume);
        //audioSource.PlayOneShot(AudioClip audioClip, Float volumeScale);
        //AudioSource.PlayClipAtPoint(clip, transform.position, volume);
        //audioData.Play(0);
    }
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
