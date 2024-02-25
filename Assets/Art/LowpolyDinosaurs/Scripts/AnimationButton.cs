using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LowpolyDinosaursAnimated
{

	public class AnimationButton : MonoBehaviour
	{
		public List<AnimationClip> _animationClipList;
		public Animator _animator;

		public void Click(AnimationClip _animationClip)
		{
			if (_animationClip.name.EndsWith("roar") || _animationClip.name.EndsWith("attack") || _animationClip.name == "Elasmosaurus_rush" || _animationClip.name == "Mosasaurus_rush")
			{
				foreach (AnimatorControllerParameter _p in _animator.parameters)
				{
					if (_p.type == AnimatorControllerParameterType.Bool)
					{
						_animator.SetBool(_p.name, false);
					}
				}
				_animator.SetTrigger(_animationClip.name);
			}
			else
			{
				foreach (AnimatorControllerParameter _p in _animator.parameters)
				{
					if (_p.type == AnimatorControllerParameterType.Bool)
					{
						_animator.SetBool(_p.name, false);
					}
				}

				if (!_animationClip.name.EndsWith("idle")){
					_animator.SetBool(_animationClip.name, true);
				}
			}
		}
	}
}
