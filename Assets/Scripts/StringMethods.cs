/*
 * PROJECT		: UNITY SPACE GAME
 * PROGRAMMER	: ANDY SGRO
 * DATE CREATED	: May 5, 2021
 * DESCRIPTION	: Has extension string methods.
 */

using System.Collections.Generic;

/**
 * NAME    : StringMethods
 * PURPOSE :
 *	- Has extension string methods.
 */
public static class StringMethods
{
	/**
	 * \brief	Compares a list of strings to a single string, checking for equality.
	 * 
	 * \param	this string str			: The string that is compared against.
	 * \param	List<string> stringList	: The list of strings that are compared against.
	 * 
	 * \return	If one of the strings in the list
	 *			matches the single string, then true is returned.
	 */
	public static bool CompareStrings(this string str, List<string> stringList)
    {
        foreach (string stringElement in stringList)
		{
            if (str.Equals(stringElement))
			{
                return true;
			}
		}
        return false;
    }
}
