using UnityEngine;

public class Vehicle : MonoBehaviour{
    private int year
    {              // ENCAPSULATION
        get { return year; }
        set { if (year > 0) {
                    year = value;
                } 
            }
    
    }

    private float speed
    {       // ENCAPSULATION
        get { return speed; }
        set { speed = value; }
    }

    public virtual void Move()
    {     // ABSTRACTION

    }

    public virtual void TurnOn()
    {      // ABSTRACTION

    }

    public virtual void TurnOff()
    {         // ABSTRACTION

    }
}
