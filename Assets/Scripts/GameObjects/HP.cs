/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 15, 2019
 * DESCRIPTION	: Manages the HP of the GameObject.
 */

using System;
using System.Collections.Generic;
using UnityEngine;


/**
 * NAME    : HP
 * PURPOSE :
 *	- Manages the HP of the GameObject.
 *	- Has callback funcitons for when the HP decrements and when it reaches zero.
 *	- Also deletes its parent GameObject when the HP reaches zero.
 */
public class HP : MonoBehaviour
{
	[SerializeField] private int _hp = 1;
	[SerializeField] List<string> loseHpOnHit = new List<string>();
	
	public int hp { get; private set; }
	List<Action<int>> decrementCallbacks = new List<Action<int>>();
	List<Action> deathCallbacks = new List<Action>();


	/**
	 * \brief	Initilizes the hp property.
	 * \param	void
	 * \return	void
	 */
	private void Start()
	{
		hp = _hp;
	}


	/**
	 * \brief	Decrements the hp when the GameObject collides with a compatible collider.
	 * \param	Collider other : The GameObject that we collided with.
	 * \return	void
	 */
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag.CompareStrings(loseHpOnHit))
		{
			Decrement();
		}
	}


	/**
	 * \brief	Decrements the hp and calls the appropriate callback functions
	 * \param	void
	 * \return	void
	 */
	public void Decrement()
	{
		--hp;
		foreach (Action<int> callback in decrementCallbacks)
		{
			callback(hp);
		}
	}


	/**
	 * \brief	Adds a callback function that triggers when the hp is reduced to zero.
	 * \param	Action callback : This gets called when the hp is reduced to zero.
	 * \return	void
	 */
	public void AddDeathCallback(Action callback)
	{
		deathCallbacks.Add(callback);
	}


	/**
	 * \brief	Adds a callback function that triggers every time the hp gets decremented.
	 * \param	Action callback : This gets called every time the hp gets decremented.
	 * \return	void
	 */
	public void AddDecrementCallback(Action<int> callback)
	{
		decrementCallbacks.Add(callback);
	}


	/**
	 * \brief	Destroys the parent GameObject when the HP reaches zero.
	 * \param	void
	 * \return	void
	 */
	private void LateUpdate()
	{
		if (hp <= 0)
		{
			foreach (Action callback in deathCallbacks)
			{
				callback();
			}
			Destroy(gameObject);
		}
	}
}
