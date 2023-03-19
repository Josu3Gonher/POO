using System.Collections.Generic;
using System.Linq;
using TareaAplicacionWeb.Models;

public class TareaService
{
    private static List<Tarea> TareasEnMemoria = new List<Tarea>();

    public static void AgregarTarea(Tarea tarea)
    {
        TareasEnMemoria.Add(tarea);
    }

    public static List<Tarea> ObtenerTodasLasTareas()
    {
        return TareasEnMemoria.ToList();
    }

    public static Tarea ObtenerTareaPorId(int id)
    {
        return TareasEnMemoria.FirstOrDefault(t => t.Id == id);
    }

    public static void ActualizarTarea(Tarea tareaActualizada)
    {
        var tareaExistente = TareasEnMemoria.FirstOrDefault(t => t.Id == tareaActualizada.Id);
        if (tareaExistente != null)
        {
            tareaExistente.Titulo = tareaActualizada.Titulo;
            tareaExistente.Descripcion = tareaActualizada.Descripcion;
            tareaExistente.FechaVencimiento = tareaActualizada.FechaVencimiento;
        }
    }

    public static List<Tarea> ObtenerTareasRecientes()
    {
        return TareasEnMemoria.OrderByDescending(t => t.FechaCreacion).Take(5).ToList();
    }
}