﻿/*
    Walking.cs
    Author: Samuel Vargas
*/

using Player;
using UnityEngine;

namespace Entities.Player.States {
  public class Walking : FiniteStateMonoBehaviour {
    private FiniteStateMachine _finiteStateMachine;
    private Animation _animation;
    private CharacterController _characterController;
    private CliffDetect _cliffDetect;

    public override void Enter() {
    }

    public override void Exit() {
    }

    private void Start() {
      _finiteStateMachine = GetComponentInParent<FiniteStateMachine>();
      _animation = GetComponentInParent<Animation>();
      _characterController = GetComponentInParent<CharacterController>();
      _cliffDetect = GetComponentInParent<CliffDetect>();
    }

    private void Update() {
      if (!_finiteStateMachine.IsActive(this)) return;
      var x = Input.GetAxis("Horizontal") * Time.deltaTime * 200.0f;
      var z = Input.GetAxis("Vertical") * Time.deltaTime;

      // Transfer back to Idling if the user has stopped walking.
      if (Mathf.Abs(x) < float.Epsilon &&
          Mathf.Abs(z) < float.Epsilon) {
        _finiteStateMachine.ChangeState(typeof(Idling).Name);
        return;
      }

      transform.parent.parent.Rotate(0, x, 0);

      if (!_cliffDetect.IsCliffInfront()) {
        var forward = transform.TransformDirection(Vector3.forward);
        _characterController.SimpleMove(forward * 1.5f);
        _animation.CrossFade("Walk");
      }
    }
  }
}