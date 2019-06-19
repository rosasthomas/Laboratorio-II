public delegate void DelegadoSueldo(Entidades.ultimaClase.Empleado e, float f);
public delegate void DelSueldo(Entidades.ultimaClase.EmpleadoMejorado eM, Entidades.ultimaClase.EmpleadoSueldoArgs sA);

public enum TipoManejador
{
    LimiteSueldo,
    Log,
    Ambos,
}