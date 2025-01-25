using UnityEngine;

public class Plane : Vehicle{   // INHERITANCE
    private float altitude
    {         // ENCAPSULATION
        get { return altitude; }
        set { altitude = value; }
    }

    public override void Move()
    {    // POLYMORPHISM

    }

    public override void TurnOn()
    {  // POLYMORPHISM

    }

    public override void TurnOff()
    { // POLYMORPHISM

    }

    public void Ascend() { 
        
    }

    public void Descend(){

    }
}
