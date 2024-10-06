using System;

public abstract class PlanGoal
{
    public String name;

    public float _value;
    public float changeOverTime;

    public PlanGoal(float _value, float changeOverTime)
    {
        this._value =_value;
        this.changeOverTime = changeOverTime;
    }

    public float GetDiscontentment()
    {
        return _value;
    }
}
