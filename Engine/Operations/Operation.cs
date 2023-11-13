using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine.Rendering;

public abstract class Operation : IComputable
{
    private float _num1;
    private float _num2;

    public float Num1
    {
        get => _num1;
        set => _num1 = value;
    }

    public float Num2
    {
        get => _num2;
        set => _num2 = value;
    }

    public abstract float Compute(float num1, float num2);

    public virtual float Compute()
    {
        return this.Compute(_num1, _num2);
    }
}