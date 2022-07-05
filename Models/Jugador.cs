using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data.SqlClient;

namespace TP6_Ayala_LopezAbraham.Models;

public class Jugador{
    private int _IdJugador, _IdEquipo;
    private string _Nombre, _Foto, _EquipoActual;
    private DateTime _FechaNacimiento;

    public Jugador()
    {}

    public Jugador(int idJugador, int idEquipo, string nombre, string foto, string equipoActual, DateTime fechaNacimiento)
    {
        _IdJugador = idJugador;
        _IdEquipo = idEquipo;
        _Nombre = nombre;
        _Foto = foto;
        _EquipoActual = equipoActual;
        _FechaNacimiento = fechaNacimiento;
    }

    public int IdJugador
    {
        get {return _IdJugador;}
        set {_IdJugador = value;}
    }
    public int IdEquipo
    {
        get {return _IdEquipo;}
        set {_IdEquipo = value;}
    }
    public string Nombre
    {
        get {return _Nombre;}
        set {_Nombre = value;}
    }
    public string Foto
    {
        get {return _Foto;}
        set {_Foto = value;}
    }
    public string EquipoActual
    {
        get {return _EquipoActual;}
        set {_EquipoActual = value;}
    }
    public DateTime FechaNacimiento
    {
        get {return _FechaNacimiento;}
        set {_FechaNacimiento = value;}
    }
}