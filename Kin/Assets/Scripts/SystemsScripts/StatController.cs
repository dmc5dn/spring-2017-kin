using UnityEngine;
using System.Collections;

public class StatController : MonoBehaviour
{

	private int healthLvlP;
	private int healthLvlO;
	private int stamLvlP;
	private int stamLvlO;
	private int strLvlP;
	private int strLvlO;
	private int wisLvlP;
	private int wisLvlO;

	// Use this for initialization
	void Awake ()
	{
		healthLvlO = 0;
		healthLvlP = 447;
		stamLvlO = 0;
		stamLvlP = 2000;
		strLvlO = 0;
		strLvlP = 0;
		wisLvlO = 0;
		wisLvlP = 57;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	//Set methods
	public void setHealth(int playerHealth)
	{
		healthLvlP = playerHealth;
	}

	public void setHealthOrder(int playerHealthOrder)
	{
		healthLvlO = playerHealthOrder;
	}

	public void setStamina(int playerStamina)
	{
		stamLvlP = playerStamina;
	}

	public void setStaminaOrder(int playerStaminaOrder)
	{
		stamLvlO = playerStaminaOrder;
	}

	public void setStrength(int playerStrength)
	{
		strLvlP = playerStrength;
	}

	public void setStrengthOrder(int playerStrengthOrder)
	{
		strLvlO = playerStrengthOrder;
	}

	public void setWisdom(int playerWisdom)
	{
		wisLvlP = playerWisdom;
	}

	public void setWisdomOrder(int playerWisdomOrder)
	{
		wisLvlO = playerWisdomOrder;
	}

    //Get methods
    public int getHealth()
    {
        return healthLvlP;
    }

    public int getHealthOrder()
    {
        return healthLvlO;
    }

    public int getStamina()
    {
        return stamLvlP;
    }

    public int getStaminaOrder()
    {
        return stamLvlO;
    }

    public int getStrength()
    {
        return strLvlP;
    }

    public int getStrengthOrder()
    {
        return strLvlO;
    }

    public int getWisdom()
    {
        return wisLvlP;
    }

    public int getWisdomOrder()
    {
        return wisLvlO;
    }
}

