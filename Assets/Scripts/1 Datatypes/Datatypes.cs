using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datatypes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() 
	{
		// Truth or Boolean Values
		bool isGrounded;    // Declaration
		isGrounded = true;  // Assignment

		// Unity specific Output
		Debug.Log("IsGrounded: " + isGrounded);

		// Integers
		int points = 50; // Initialization 
		long limit = long.MaxValue; 
		// integer max value:        2147483648
		// long max value:  9223372036854775807

		Debug.Log("Points: " + points + " / " + limit);

		// Floating-Point numbers
		float damage = 3.5f;
		double bigDamage = 100.01;

		Debug.Log("Damage: " + damage);
		Debug.Log("Big Damage: " + bigDamage);

		// Character
		char letter = 'a';  // single character with Single Quotes '
		string playerName = "Nico"; // multiple characters with Double Quotes "

		Debug.Log("The Character \"a\": " + letter);
		Debug.Log("Player 1: " + playerName);

		// Implicit Types
		var totalPoints = 100;
		var player2Name = "James";

		Debug.Log("Player 2: " + player2Name);
		Debug.Log("Points: " + totalPoints);

		// string test = null;

	}
}
