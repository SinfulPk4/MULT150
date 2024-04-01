using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    

    void Start()
    {
    int birthdayMonth = 5;
    int birthdayDay = 21;
        // Outputting months
        for (int month = 1; month <= 12; month++)
        {
            if (month == birthdayMonth)
            {
                Debug.Log("It's my birthday!");
            }
            else
            {
                Debug.Log(month);
            }
        }

        // Outputting days of the birthday month
        int daysInBirthdayMonth = System.DateTime.DaysInMonth(System.DateTime.Now.Year, birthdayMonth);
        for (int day = 1; day <= daysInBirthdayMonth; day++)
        {
            if (day == birthdayDay)
            {
                Debug.Log("It's my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }
}
