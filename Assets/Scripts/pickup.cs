using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour {

	public Rigidbody rb;
    public Text level;
    private int oxygenLevel;
    private int x = 0;
	// Use this for initialization
	void Start () {
		rb = GetComponent < Rigidbody>();
        oxygenLevel = 100;
       

    }
    private void FixedUpdate()
    {
        x++;
        if(x==700)
        {
            oxygenLevel -= 1;
            x = 0;
        }
        setLevelText();
    }
    void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Pick Up"))
		{
			other.gameObject.SetActive(false);
            oxygenLevel += 10;
            setLevelText();
        }
	}
    void setLevelText()
    {
        if(oxygenLevel>100)
        {
            oxygenLevel = 100;
        }
        if (oxygenLevel > 0)
        {
            level.text = "O2: " + oxygenLevel.ToString();

        }
        else
        {
            level.text = "Oh no, you don't have any oxygen left. But give us a like to be back to full health";
        }
}
